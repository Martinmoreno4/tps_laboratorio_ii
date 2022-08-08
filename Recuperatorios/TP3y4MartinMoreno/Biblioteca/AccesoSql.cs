using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca
{
    public class AccesoSql
    {
        SqlConnection conexion;
        SqlCommand comando;

        public AccesoSql()
        {
            conexion = new SqlConnection(@"Data Source=.;Database=TP4-MartinMoreno;Trusted_Connection=True;");

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public List<Implementos> Leer()
        {
            List<Implementos> biblioteca = new List<Implementos>();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT Implemento.Nombre as nombre, Implemento.Cantidad as cantidad, Implemento.ID as id FROM Implemento";

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        biblioteca.Add(new Implementos(dataReader["nombre"].ToString(), (int)dataReader["cantidad"], (int)dataReader["id"]));
                    }
                }

            }
            finally
            {
                conexion.Close();
            }

            return biblioteca;
        }

        public void Eliminar(int Id)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM Implemento WHERE ID = {Id}";
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }

        public int Insertar(Implementos implemento, Action<string> mostrarElementos)
        {
            try
            {
                List<string> auxLista = new List<string>();

                if (string.IsNullOrEmpty(implemento.Nombre) || implemento.Cantidad < 1)
                {
                    throw new DatosInvalidosException("Error,los datos ingresados no son validos. Reingrese");
                }
                else
                {
                    mostrarElementos("se agregaron los datos");

                    comando.CommandText = "Insert into Implemento values (@Nomb, @Cant) ";
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Nomb", implemento.Nombre);
                    comando.Parameters.AddWithValue("@Cant", implemento.Cantidad);

                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    return comando.ExecuteNonQuery();
                    
                }
            }
            catch (DatosInvalidosException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }

        }

        public int Insertar(Implementos implemento)
        {
            try
            {
                List<string> auxLista = new List<string>();

                if (string.IsNullOrEmpty(implemento.Nombre) || implemento.Cantidad < 1)
                {
                    throw new DatosInvalidosException("Error,los datos ingresados no son validos. Reingrese");
                }
                else
                {

                    comando.CommandText = "Insert into Implemento values (@Nomb, @Cant) ";
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@Nomb", implemento.Nombre);
                    comando.Parameters.AddWithValue("@Cant", implemento.Cantidad);

                    if (conexion.State != ConnectionState.Open)
                    {
                        conexion.Open();
                    }

                    return comando.ExecuteNonQuery();

                }
            }
            catch (DatosInvalidosException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexion.Close();
            }

        }
    }
}

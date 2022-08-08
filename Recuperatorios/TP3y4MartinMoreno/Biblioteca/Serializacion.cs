using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    public static class Serializacion<T>
    {

        public static void Escribir(T datos, string ruta, string nombreArchivo)
        {
            string completa = ruta + nombreArchivo + ".json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string objetoJson = JsonSerializer.Serialize(datos);
                if (!string.IsNullOrEmpty(objetoJson))
                {
                    File.WriteAllText(completa, objetoJson);
                }

            }
            catch (Exception e)
            {
                throw new Exception($"Error en la creacion del archivo {nombreArchivo}");
            }
        }

        public static T Leer(string nombre, string ruta)
        {
            string archivo = string.Empty;

            T datos = default;

            try
            {
                if (Directory.Exists(ruta))
                {
                    string[] archivosEnRuta = Directory.GetFiles(ruta);

                    foreach (string archivoEnRuta in archivosEnRuta)
                    {
                        if (archivoEnRuta.Contains(nombre))
                        {
                            archivo = archivoEnRuta;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        string archivoJson = File.ReadAllText(archivo);
                        datos = (T)JsonSerializer.Deserialize<T>(archivoJson);
                    }
                }
                return datos;

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {archivo}");
            }
        }

        
        public static int agregarSerilizacion(Usuario usuario, List<Usuario> usuarios, string ruta, string nombreArchivo)
        {
            try
            {
                List<string> auxLista = new List<string>();

                if (usuario.DNI <10000000 || string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Apellido) || string.IsNullOrEmpty(usuario.Genero) ||
                   usuario.Telefono <1000000000 || string.IsNullOrEmpty(usuario.Dia))
                {
                    throw new DatosInvalidosException("Error,los datos ingresados no son validos. Reingrese");
                }else
                {
                    usuarios.Add(usuario);
                    Serializacion<List<Usuario>>.Escribir(usuarios, ruta, nombreArchivo);
                    return 1;
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
        }
    }
}

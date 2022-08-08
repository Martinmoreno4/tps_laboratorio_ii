using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Implementos
    {

        private string nombre;
        private int cantidad;
        private int id;

        public Implementos()
        {

        }


        public Implementos(string nombre, int cantidad):this()
        {
            this.nombre = nombre;
            this.cantidad = cantidad;

        }

        public Implementos(string nombre, int cantidad, int id) : this(nombre, cantidad)
        {

            this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id { get => id; set => id = value; }

    }
}

using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Usuario: IDias
    {
        
        private string nombre;
        private string apellido;
        private string genero;
        private int telefono;
        private int dni;
        private string diaClase;


        public Usuario()
        {

        }

        public Usuario(int dni, string nombre, string apellido, string genero, int telefono, string diaClase):this()
        {
            
            this.nombre = nombre;
            this.genero = genero;
            this.telefono = telefono;
            this.dni = dni;
            this.diaClase = diaClase;
            this.Apellido = apellido;
        }

        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int DNI { get => dni; set => dni = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public string Dia
        {
            get
            {
                return diaClase;
            }
        }
    }
}

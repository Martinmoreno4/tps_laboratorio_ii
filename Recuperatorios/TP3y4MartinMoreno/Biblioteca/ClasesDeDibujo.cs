using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClasesDeDibujo : IDias
    {
        private string dia;
        private string Horarios;

        public ClasesDeDibujo()
        {

        }

        public ClasesDeDibujo(string dia, string horarios):this()
        {
            this.dia = dia;
            this.Horarios = horarios;
        }

        public string Dia
        {
            get
            {
                return dia;
            }
        }
        public string Horarios1 { get => Horarios; set => Horarios = value; }
    }
}

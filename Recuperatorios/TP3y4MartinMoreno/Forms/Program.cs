using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    internal static class Program
    {

        public static List<Implementos> Implementos = new List<Implementos>();
        public static List<ClasesDeDibujo> Clases = new List<ClasesDeDibujo>();
        public static List<Usuario> usuarios = new List<Usuario>();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }
    }
}

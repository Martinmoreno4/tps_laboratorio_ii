using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            ActualizarReloj();
        }

        private void btnUsuariosLista_Click(object sender, EventArgs e)
        {
            ListaUsuario menu = new ListaUsuario();
            menu.Show();
            
        }

        private void btnImplementosLista_Click(object sender, EventArgs e)
        {
            ListaImplementos menu = new ListaImplementos();
            menu.Show();
            
        }

        private void btnClasesLista_Click(object sender, EventArgs e)
        {
            ListaClases menu = new ListaClases();
            menu.Show();
            
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Usuario usuario1 = new Usuario(37564521, "Fernando", "Aguirre", "Masculino", 1145696874, "Lunes");
            Usuario usuario2 = new Usuario(36324544, "Maria", "Fernandez", "Femenino", 1169216674, "Martes");
            Usuario usuario3 = new Usuario(35869441, "Alejandro", "Aguirre", "Masculino", 1184325678, "Jueves");
            Program.usuarios.Add(usuario1);
            Program.usuarios.Add(usuario2);
            Program.usuarios.Add(usuario3);
            ClasesDeDibujo lunes = new ClasesDeDibujo("Lunes","12:00 - 16:00");
            ClasesDeDibujo martes = new ClasesDeDibujo("Martes", "12:00 - 16:00");
            ClasesDeDibujo miercoles = new ClasesDeDibujo("Miercoles", "12:00 - 16:00");
            ClasesDeDibujo jueves = new ClasesDeDibujo("Jueves", "12:00 - 16:00");
            ClasesDeDibujo viernes = new ClasesDeDibujo("Viernes", "12:00 - 16:00");
            Program.Clases.Add(lunes);
            Program.Clases.Add(martes);
            Program.Clases.Add(miercoles);
            Program.Clases.Add(jueves);
            Program.Clases.Add(viernes);
        }

        private void ActualizarReloj()
        {
            Task task = Task.Run(() =>
            {
                do
                {
                    AsignarFechaYHora();
                    Thread.Sleep(1000);
                } while (true);
            });
        }

        private void AsignarFechaYHora()
        {
            if (labelHora.InvokeRequired)
            {
                Action delegadoAsignarHora = AsignarFechaYHora;
                labelHora.Invoke(delegadoAsignarHora);
            }
            else
            {
                labelHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        public static void CerrarMenu(Form menu)
        {
            menu.Close();
        }
    }
}

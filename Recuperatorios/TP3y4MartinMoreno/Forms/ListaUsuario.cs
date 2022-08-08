using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ListaUsuario : Form
    {
        private MainPage mainPage;
        public ListaUsuario()
        {
            InitializeComponent();
            SerilaizarYDeserializar();
        }

        private void btnCancelarUs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AvisoUsuarios menu = new AvisoUsuarios();
            menu.Show();
            this.Close();
        }



        private void SerilaizarYDeserializar()
        {
            string rutaFile = string.Empty;
            rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TP3-4 MARTIN MORENO\\";
            List<Usuario> listaUsuarios = Program.usuarios;
            Serializacion<List<Usuario>>.Escribir(listaUsuarios, rutaFile, "Usuarios");
            List<Usuario> Usuarios = Serializacion<List<Usuario>>.Leer("Usuarios", rutaFile);
            dataGridView1.DataSource = Usuarios;
        }


    }
}

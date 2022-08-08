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
    public partial class AvisoUsuarios : Form
    {
        public AvisoUsuarios()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Agregar(new Usuario(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, CBoxGenero.Text, int.Parse(txtTelefono.Text), CBoxClase.Text)) ==1)
                {
                    MessageBox.Show("Se ha insertado el Usuario correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha podido insertar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void btnCancAvUs_Click(object sender, EventArgs e)
        {
            ListaUsuario menu = new ListaUsuario();
            menu.Show();
            this.Close();
        }

        public int Agregar(Usuario usuario)
        {
            string rutaFile = string.Empty;
            rutaFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TP3-4 MARTIN MORENO\\";
            List<Usuario> Usuarios = Serializacion<List<Usuario>>.Leer("Usuarios", rutaFile);
            if(Serializacion<Usuario>.agregarSerilizacion(usuario, Usuarios, rutaFile, "Usuarios")==1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}

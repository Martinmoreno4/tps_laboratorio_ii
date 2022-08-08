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
    public partial class ListaClases : Form
    {
        public ListaClases()
        {
            InitializeComponent();
            ListarClases();
        }

        private void btnCancelarCl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarClases()
        {
            listClases.Items.Clear();
            if (Program.Clases is not null)
            {
                foreach (ClasesDeDibujo clas in Program.Clases)
                {
                    if (clas is not null)
                    {
                        string[] fila = { clas.Dia, clas.Horarios1};
                        ListViewItem item = new ListViewItem(fila);
                        listClases.Items.Add(item);
                    }
                }
            }
        }
    }
}

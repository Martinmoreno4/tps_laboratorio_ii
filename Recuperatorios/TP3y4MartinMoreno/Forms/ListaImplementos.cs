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
    public partial class ListaImplementos : Form
    {
        AccesoSql accesoSql;
       
        public ListaImplementos()
        {
            InitializeComponent();
            accesoSql = new AccesoSql();
        }
        private void ListaImplementos_Load(object sender, EventArgs e)
        {
            try
            {
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarIm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAgregarImp_Click(object sender, EventArgs e)
        {
            try
            {
                AvisoImplementos menu = new AvisoImplementos();

                if (menu.ShowDialog() == DialogResult.OK)
                {
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Refrescar()
        {
            dtgImplementos.DataSource = accesoSql.Leer();
            dtgImplementos.Refresh();
            dtgImplementos.Update();
        }


        private void btnEliminiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgImplementos.SelectedRows.Count > 0)
                {
                    Implementos implemento = (Implementos)dtgImplementos.CurrentRow.DataBoundItem;

                    accesoSql.Eliminar(implemento.Id);
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

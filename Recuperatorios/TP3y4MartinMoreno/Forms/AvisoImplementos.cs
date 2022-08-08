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
    public partial class AvisoImplementos : Form
    {
        AccesoSql manejador;

        public event Action<bool> CantidadExcesiva;
        public AvisoImplementos()
        {
            InitializeComponent();
            manejador = new AccesoSql();
            CantidadExcesiva += MostrarMensajeAviso;
        }

        private void ActualizarAviso(string texto)
        {
            lblAviso.Text = texto;
            lblAviso.Visible = true;
        }

        private void btnAceptImpAv_Click(object sender, EventArgs e)
        {
            try
            {
                Implementos implemento = new Implementos(txtNombre.Text, int.Parse(txtCant.Text));
                if (manejador.Insertar(implemento, ActualizarAviso) != 1)
                {
                    MessageBox.Show("No se ha podido insertar");
                }
                else
                {
                    CantExcesiva(implemento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancImpAv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarMensajeAviso(bool condicion)
        {
            if (condicion)
            {
                MessageBox.Show("por favor poner menos cantidad en la casilla para la proxima");
            }
        }

        public void CantExcesiva(Implementos implemento)
        {
            if (implemento.Cantidad >= 60)
            {
                CantidadExcesiva.Invoke(true);
            }
        }


    }
}

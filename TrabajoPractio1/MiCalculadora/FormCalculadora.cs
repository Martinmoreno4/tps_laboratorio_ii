using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_TP1;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(txtNumero1.Text!=null && txtNumero2.Text!=null) 
            {
                lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
                //double result = 0;
                switch (cmbOperador.Text)
                {
                    case "+":
                        {
                            lstOperaciones.Items.Add($" {txtNumero1.Text} + {txtNumero2.Text} = {lblResultado.Text}");
                            break;
                        }
                    case "-":
                        {
                            lstOperaciones.Items.Add($" {txtNumero1.Text} - {txtNumero2.Text} = {lblResultado.Text}");
                            break;
                        }
                    case "*":
                        {
                            lstOperaciones.Items.Add($" {txtNumero1.Text} * {txtNumero2.Text} = {lblResultado.Text}");
                            break;
                        }
                    case "/":
                        {
                            lstOperaciones.Items.Add($" {txtNumero1.Text} / {txtNumero2.Text} = {lblResultado.Text}");
                            break;
                        }
                }
            }
            else
            {
                lblResultado.Text = "0";
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                string binario = Operando.DecimalBinario(lblResultado.Text);
                lblResultado.Text = binario;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "0")
            {
                string decimal1 = Operando.BinarioDecimal(lblResultado.Text);
                lblResultado.Text = decimal1;
            }
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            cmbOperador.Items.Add("");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
            cmbOperador.SelectedIndex = 0;
        }


        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            foreach(char c in operador)
            {
                return Calculadora.Operar(operando1, operando2, c);
            }
            return 0;
        }

        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedItem = "";
        }
    }
}

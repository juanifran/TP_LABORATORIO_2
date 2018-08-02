using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza el calculo usando el metodo Operar de la clase Calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero numero1 = new Numero(this.txtNumero1.Text);
            Numero numero2 = new Numero(this.txtNumero2.Text);

            Calculadora c1 = new Calculadora();
            lblResultado.Text = c1.Operar(numero1, numero2, this.cmbOperador.Text).ToString();
        }

        /// <summary>
        /// Limpia los valores de los campos de texto, el label
        /// y el combobox de la interfaz
        /// </summary>
        public void LimpiarForm()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = "";
            this.cmbOperador.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarForm();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            long num = Convert.ToInt32(txtNumero1.Text);
            if (num > 0)
            {
                Numero n1 = new Numero();
                this.lblResultado.Text = n1.DecimalBinario(txtNumero1.Text);
            }
            else
            {
                if (num < 0)
                    MessageBox.Show("Solo numeros positivos");
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            long num = Convert.ToInt32(txtNumero1.Text);
            if (num > 0)
            {
                Numero n1 = new Numero();
                this.lblResultado.Text = n1.BinarioDecimal(txtNumero1.Text);
            }
            else
            {
                if (num < 0)
                    MessageBox.Show("Solo numeros positivos");
            }
        }
    }
}

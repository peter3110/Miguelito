using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Binario a Decimal
        int largoNumero, numBin = 0, resultado = 0, potencia = 1, i = 0;
        string stringNumero;

        // Decimal a Binario
        int numDec, division, resto;
        string binario;

        public Form1()
        {
            InitializeComponent();
        }
        private void txtBinarioaDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D1) || (byte)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if ((byte)e.KeyChar == 100)
            {
                btnBinarioaDecimal.PerformClick();
            }
        }
        private void txtDecimalaBinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9) || (byte)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if ((byte)e.KeyChar == 98)
            {
                btnDecimalaBinario.PerformClick();
            }
        }
        private void btnBinarioaDecimal_Click_1(object sender, EventArgs e)
        {
            if (txtBinarioaDecimal.Text != "")
            {
                largoNumero = txtBinarioaDecimal.Text.Length;
                for (i = largoNumero; i > 0; i--)
                {
                    stringNumero = txtBinarioaDecimal.Text.Substring(i - 1, 1);
                    numBin = Convert.ToInt32(stringNumero);
                    resultado = resultado + (numBin * potencia);
                    potencia = potencia * 2;
                }
                lblBinarioADecimal.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
        private void btnDecimalaBinario_Click(object sender, EventArgs e)
        {
            if (txtDecimalaBinario.Text != "")
            {
                numDec = Convert.ToInt32(txtDecimalaBinario.Text);
                while (numDec > 0)
                {
                    division = numDec / 2;
                    resto = numDec % 2;
                    numDec = division;
                    binario = Convert.ToString(resto) + binario;
                }
                lblDecimalABinario.Text = Convert.ToString(binario);
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnBorrar0_Click(object sender, EventArgs e)
        {
            txtBinarioaDecimal.Clear();
            lblBinarioADecimal.Text = "";
            resultado = 0;
            numBin = 0;
            largoNumero = 0;
            potencia = 1;
            i = 0;
        }

        private void btnBorrar1_Click(object sender, EventArgs e)
        {
            txtDecimalaBinario.Clear();
            lblDecimalABinario.Text = "";
            binario = "";
            numDec = 0;
        }
    }
}

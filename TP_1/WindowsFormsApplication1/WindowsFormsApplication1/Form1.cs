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
        float num1, num2, resultado;
        char operacion;
        public Form1()
        {
            InitializeComponent();
        }
        private void txtCuenta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9) || (byte)e.KeyChar == 8 || e.KeyChar == ',' || e.KeyChar == '-' || (byte)e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if ((byte)e.KeyChar == 13) // Enter
            {
                btnIgual.PerformClick();
            }
            else
            {
                if ((byte)e.KeyChar == 43) // El más
                {
                    btnSuma.PerformClick();
                }
                else
                {
                    if ((byte)e.KeyChar == 45) // El menos
                    {
                        btnResta.PerformClick();
                    }
                    else 
                    {
                        if ((byte)e.KeyChar == 47) // El dividido
                        {
                            btnDivision.PerformClick();
                        }
                        else
                        {
                            if ((byte)e.KeyChar == 42) // El multiplicador
                            {
                                btnMultiplicacion.PerformClick();
                            }
                        }
                    }
                }
            }
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;
        }
        private void btnSuma_Click_1(object sender, EventArgs e)
        {
            if (txtCuenta.Text != "")
            {
                num1 = Convert.ToSingle(txtCuenta.Text);
                txtCuenta.Clear();
                txtCuenta.Focus();
                operacion = '+';
            }
            else
            {
                MessageBox.Show("Math ERROR");
            }
        }
        private void btnResta_Click_1(object sender, EventArgs e)
        {
            if (txtCuenta.Text != "")
            {
                num1 = Convert.ToSingle(txtCuenta.Text);
                txtCuenta.Clear();
                txtCuenta.Focus();
                operacion = '-';
            }
            else
            {
                MessageBox.Show("Math ERROR");
            }
        }
        private void btnMultiplicacion_Click_1(object sender, EventArgs e)
        {
            if (txtCuenta.Text != "")
            {
                num1 = Convert.ToSingle(txtCuenta.Text);
                txtCuenta.Clear();
                txtCuenta.Focus();
                operacion = '*';
            }
            else
            {
                MessageBox.Show("Math ERROR");
            }
        }
        private void btnDivision_Click_1(object sender, EventArgs e)
        {
            if (txtCuenta.Text != "")
            {
                num1 = Convert.ToSingle(txtCuenta.Text);
                txtCuenta.Clear();
                txtCuenta.Focus();
                operacion = '/';
            }
            else
            {
                MessageBox.Show("Math ERROR");
            }
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtCuenta.Clear();
            txtCuenta.Focus();
            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnDivision.Enabled = true;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(txtCuenta.Text != "")
            {
                if (operacion == '+')
                {
                    num2 = Convert.ToSingle(txtCuenta.Text);
                    resultado = num1 + num2;
                    txtCuenta.Text = Convert.ToString(resultado);
                }
                else if (operacion == '-')
                {
                    num2 = Convert.ToSingle(txtCuenta.Text);
                    resultado = num1 - num2;
                    txtCuenta.Text = Convert.ToString(resultado);
                }
                else if (operacion == '*')
                {
                    num2 = Convert.ToSingle(txtCuenta.Text);
                    resultado = num1 * num2;
                    txtCuenta.Text = Convert.ToString(resultado);
                }
                else if (operacion == '/')
                {
                    num2 = Convert.ToSingle(txtCuenta.Text);
                    if (num2 > 0)
                    {
                        resultado = num1 / num2;
                        txtCuenta.Text = Convert.ToString(resultado);
                    }
                    else
                    {
                        MessageBox.Show("Math ERROR");
                    }
                }
                btnSuma.Enabled = true;
                btnResta.Enabled = true;
                btnMultiplicacion.Enabled = true;
                btnDivision.Enabled = true;
            }
            else
            {
                MessageBox.Show("Math ERROR");
            }
        }
    }
}

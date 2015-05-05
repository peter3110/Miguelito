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
        char operacion, coma = ',', menos = '-';
        public Form1()
        {
            InitializeComponent();
        }
        private void txtCuenta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9) || (byte)e.KeyChar == 8|| e.KeyChar == coma || e.KeyChar == menos || (byte)e.KeyChar == 13)
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
                    if ((byte)e.KeyChar == 47) // El dividido
                    {
                        btnDivision.PerformClick();
                    }   
                    else
                    {
                        if ((byte)e.KeyChar == 42) // El multiplicado
                        {
                            btnMultiplicacion.PerformClick();
                        }
                        else
                        {
                            if ((byte)e.KeyChar == 27) // El ESC
                            {
                                btnClear.PerformClick();
                            }
                            else
                            {
                                if (e.KeyChar == coma)
                                {
                                    if (txtCuenta.Text != "" && txtCuenta.Text != "-")
                                    {
                                        if(txtCuenta.Text.Contains(coma))
                                        {
                                            e.Handled = true;
                                        }
                                        else
                                        {
                                            e.Handled = false;
                                        }
                                    }
                                    else
                                    {
                                        e.Handled = true;
                                    }
                                }
                                else if (e.KeyChar == menos)
                                {
                                    if (txtCuenta.SelectionStart == 0)
                                    {
                                        e.Handled = false;
                                    }
                                    else
                                    {
                                        btnResta.PerformClick();
                                        e.Handled = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnSuma_Click_1(object sender, EventArgs e)
        {
            if (txtCuenta.Text != "")
            {
                if (txtCuenta.Text != "-" && txtCuenta.Text != ",")
                {
                    num1 = Convert.ToSingle(txtCuenta.Text);
                    txtCuenta.Clear();
                    txtCuenta.Focus();
                    operacion = '+';
                    btnSuma.Enabled = false;
                    btnResta.Enabled = false;
                    btnMultiplicacion.Enabled = false;
                    btnDivision.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Math ERROR");
                    txtCuenta.Clear();
                    txtCuenta.Focus();
                    num1 = 0;
                    num2 = 0;
                }
            }
            else
            {
                MessageBox.Show("Math ERROR");
                txtCuenta.Focus();
            }
        }
        private void btnResta_Click_1(object sender, EventArgs e)
        {
            if (txtCuenta.Text != "")
            {
                if (txtCuenta.Text != "-" && txtCuenta.Text != ",")
                {
                    num1 = Convert.ToSingle(txtCuenta.Text);
                    txtCuenta.Clear();
                    txtCuenta.Focus();
                    operacion = '-';
                    btnSuma.Enabled = false;
                    btnResta.Enabled = false;
                    btnMultiplicacion.Enabled = false;
                    btnDivision.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Math ERROR");
                    txtCuenta.Clear();
                    txtCuenta.Focus();
                    num1 = 0;
                    num2 = 0;
                }
            }
            else
            {
                MessageBox.Show("Math ERROR");
                txtCuenta.Focus();
            }
        }
        private void btnMultiplicacion_Click_1(object sender, EventArgs e)
        {
            if (txtCuenta.Text != "")
            {
                if (txtCuenta.Text != "-" && txtCuenta.Text != ",")
                {
                    num1 = Convert.ToSingle(txtCuenta.Text);
                    txtCuenta.Clear();
                    txtCuenta.Focus();
                    operacion = '*';
                    btnSuma.Enabled = false;
                    btnResta.Enabled = false;
                    btnMultiplicacion.Enabled = false;
                    btnDivision.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Math ERROR");
                    txtCuenta.Clear();
                    txtCuenta.Focus();
                    num1 = 0;
                    num2 = 0;
                }
            }
            else
            {
                MessageBox.Show("Math ERROR");
                txtCuenta.Focus();
            }
        }
        private void btnDivision_Click_1(object sender, EventArgs e)
        {
            if (txtCuenta.Text != "")
            {
                if (txtCuenta.Text != "-" && txtCuenta.Text != ",")
                {
                    num1 = Convert.ToSingle(txtCuenta.Text);
                    if (num1 != 0)
                    {
                        txtCuenta.Clear();
                        txtCuenta.Focus();
                        operacion = '/';
                        btnSuma.Enabled = false;
                        btnResta.Enabled = false;
                        btnMultiplicacion.Enabled = false;
                        btnDivision.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Math ERROR");
                        txtCuenta.Clear();
                        txtCuenta.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Math ERROR");
                    txtCuenta.Clear();
                    txtCuenta.Focus();
                    num1 = 0;
                    num2 = 0;
                }
            }
            else
            {
                MessageBox.Show("Math ERROR");
                txtCuenta.Focus();
            }
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtCuenta.Clear();
            txtCuenta.Focus();
            num1 = 0;
            num2 = 0;
            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnDivision.Enabled = true;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtCuenta.Text != "")
            {
                if (txtCuenta.Text != "-" && txtCuenta.Text != ",")
                {
                    num2 = Convert.ToSingle(txtCuenta.Text);
                    if (operacion == '+')
                    {
                        resultado = num1 + num2;
                        txtCuenta.Text = Convert.ToString(resultado);
                    }
                    else if (operacion == '-')
                    {
                        resultado = num1 - num2;
                        txtCuenta.Text = Convert.ToString(resultado);
                        resultado = num1;
                        num1 = num2;
                    }
                    else if (operacion == '*')
                    {
                        resultado = num1 * num2;
                        txtCuenta.Text = Convert.ToString(resultado);
                        num1 = num2;
                        resultado = num1;
                    }
                    else if (operacion == '/')
                    {
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            txtCuenta.Text = Convert.ToString(resultado);
                        }
                        else
                        {
                            MessageBox.Show("Math ERROR");
                            txtCuenta.Clear();
                            txtCuenta.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Math ERROR");
                    txtCuenta.Clear();
                    txtCuenta.Focus();
                    num1 = 0;
                    num2 = 0;
                }
            }
            else
            {
                MessageBox.Show("Math ERROR");
                txtCuenta.Focus();
            }
            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnMultiplicacion.Enabled = true;
            btnDivision.Enabled = true;
        }
    }
}
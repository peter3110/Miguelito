using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalcular.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            if (txtNum1.Text != "" && txtNum2.Text != "" && txtNum3.Text != "")
            {
                num1 = Convert.ToInt32(txtNum1.Text);
                num2 = Convert.ToInt32(txtNum2.Text);
                num3 = Convert.ToInt32(txtNum3.Text);
                btnCalcular.Visible = true;

                if (num1 == num2 && num1 == num3 && num2 == num3)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {   if (num1 > num2 && num1 > num3 && num2 > num3)
                    {
                    MessageBox.Show(num3 + " < " + num2 + " < " + num1);
                    }
                    if (num1 > num2 && num1 < num3)
                    {
                        MessageBox.Show(num2 + " < " + num1 + " < " + num3);
                    }
                    else if (num1 > num3 && num3 > num2)
                    {
                        MessageBox.Show(num2 + " < " + num3 + " < " + num1);
                    }
                    else if (num3 > num2 && num2 > num1)
                    {
                        MessageBox.Show(num1 + " < " + num2 + " < " + num3);
                    }
                    else if (num2 > num1 && num1 > num3)
                    {
                        MessageBox.Show(num3 + " < " + num1 + " < " + num2);
                    }
                    else if (num2 > num3 && num3 > num1)
                    {
                        MessageBox.Show(num1 + " < " + num3 + " < " + num2);
                    }
                }
            }
            else
            {
                btnCalcular.Visible = true;
                MessageBox.Show("ERROR");
            }
        }

        private void txtNum3_TextChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "" && txtNum3.Text != "")
            {
                btnCalcular.Visible = true;
            }
            else
            {
                btnCalcular.Visible = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "" && txtNum3.Text != "")
            {
                btnCalcular.Visible = true;
            }
            else
            {
                btnCalcular.Visible = false;
            }
        }
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "" && txtNum3.Text != "")
            {
                btnCalcular.Visible = true;
            }
            else
            {
                btnCalcular.Visible = false;
            }
        }
    }
}
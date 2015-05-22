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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int precio = Convert.ToInt32(txtPrecio.Text);
            int edad = Convert.ToInt32(txtEdad.Text);

            if (edad <= 5)
            {
                lblResultado.Text = "No pagas nada";
            }
            else
            {
                if (6 <= edad && edad <= 11)
                {
                    lblResultado.Text = Convert.ToString(precio / 2);

                }
                else
                {
                    if (11 < edad && edad <= 18)
                    {
                        lblResultado.Text = Convert.ToString(precio / 10 * 8);

                    }
                    else
                    {
                        if (18 < edad)
                        {
                            lblResultado.Text = Convert.ToString(precio);

                        }
                    }
                }
            }
        }
    }
}

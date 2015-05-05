using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            int num1, num2, promedio;
            string nombre;

            if (txtNota1.Text != "" && txtNota2.Text != "" && txtNombre.Text != "")
            {
                num1 = Convert.ToInt32(txtNota1.Text);
                num2 = Convert.ToInt32(txtNota2.Text);
                nombre = Convert.ToString(txtNombre.Text);
                promedio = (num1 + num2) / 2;

                if (promedio >= 6)
                {
                    MessageBox.Show(nombre + " aprobó");
                }
                else if (promedio < 6)
                {
                    MessageBox.Show(nombre + " no aprobó");
                }
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}

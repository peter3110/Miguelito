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

        private void btnClick_Click(object sender, EventArgs e)
        {
            cmbTabla.Items.Clear();

            int numero = Convert.ToInt32(txtNumero.Text);

            for (int i = 1; i <= 10; i++){

                cmbTabla.Items.Add(Convert.ToString(numero) + " x " + Convert.ToString(i) + " = " + Convert.ToString(numero * i));

            } 
        }
    }
}

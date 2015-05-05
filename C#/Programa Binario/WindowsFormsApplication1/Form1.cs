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
        int num, division, resto;
        string resultadoFinal1, resultadoFinal0, Final;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCuenta_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtIngresar.Text);
            while (num > 1)
            {
                division = num / 2;
                resto = num % 2;
                num = division;
                if (resto == 0)
                {
                    resultadoFinal0 = "0";
                    Final = resultadoFinal0;
                }
                else if (resto == 1)
                {
                    resultadoFinal1 = "1";
                    Final = resultadoFinal1;
                }
            }
            MessageBox.Show(Final);
        }
    }
}

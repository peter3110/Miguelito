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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float baseTriangulo, alturaTriangulo, baseRectangulo, alturaRectangulo, radioCirculo, diametroCirculo,
                cuentaTrianguloSuperficie, cuentaRectanguloPerimetro, cuentaRectanguloSuperficie,
                cuentaCirculoPerimetro, cuentaCirculoSuperficie, pi;

            pi = 3.14F;

            if (rbtTriangulo.Checked == true)
            {
                baseTriangulo = Convert.ToSingle(txtBaseTriangulo.Text);
                alturaTriangulo = Convert.ToSingle(txtAlturaTriangulo.Text);
                cuentaTrianguloSuperficie = (baseTriangulo * alturaTriangulo) / 2;
                lblSuperficieTrResultado.Text = Convert.ToString(cuentaTrianguloSuperficie);
            }
            else 
            {
                if(rbtRectangulo.Checked == true)
                {
                    baseRectangulo = Convert.ToSingle(txtBaseRectandulo.Text);
                    alturaRectangulo = Convert.ToSingle(txtAlturaRectangulo.Text);
                    cuentaRectanguloPerimetro = baseRectangulo * 2 + alturaRectangulo * 2;
                    cuentaRectanguloSuperficie = baseRectangulo * alturaRectangulo;
                    lblPerimetroRecResultado = Convert.ToString(cuentaRectanguloPerimetro);
                    lblSuperficieRecResultado = Convert.ToString(cuentaRectanguloSuperficie);
                }
                else if(rbtCirculo.Checked == true)
                {
                    radioCirculo = Convert.ToSingle(txtRadioCirculo.Text);
                    diametroCirculo = Convert.ToSingle(txtDiametroCirculo.Text);
                    cuentaCirculoPerimetro = pi * diametroCirculo;
                    cuentaCirculoSuperficie = pi * (radioCirculo * radioCirculo);
                }
            }
        }
    }
}

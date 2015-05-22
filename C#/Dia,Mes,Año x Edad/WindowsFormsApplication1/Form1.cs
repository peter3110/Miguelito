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
        int mesdehoy, diadehoy, aniodehoy;
        int aniofinal, mesquecumple, diaquecumple, AnioSeleccionado, anio2000 = 2000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMes.Items.Add("Enero"); // 0
            cmbMes.Items.Add("Febrero"); // 1
            cmbMes.Items.Add("Marzo"); // 2
            cmbMes.Items.Add("Abril"); // 3
            cmbMes.Items.Add("Mayo"); // 4
            cmbMes.Items.Add("Junio"); // 5
            cmbMes.Items.Add("Julio"); // 6
            cmbMes.Items.Add("Agosto"); // 7
            cmbMes.Items.Add("Septiembre"); // 8
            cmbMes.Items.Add("Octubre"); // 9
            cmbMes.Items.Add("Noviembre"); // 10
            cmbMes.Items.Add("Diciembre"); // 11

            mesdehoy = DateTime.Now.Month;
            aniodehoy = DateTime.Now.Year;
            diadehoy = DateTime.Now.Day;
            for (int i = 1950; i <= aniodehoy; i++)
                cmbAnio.Items.Add(i);
            for (int j = 1; j <= 31; j++)
                cmbDia.Items.Add(j);
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            AnioSeleccionado = Convert.ToInt32(cmbAnio.SelectedItem.ToString());
            if (AnioSeleccionado <= anio2000)
            {
                aniofinal = (aniodehoy - Convert.ToInt32(cmbAnio.SelectedItem.ToString())) - 1;
            }
            else {
                aniofinal = aniodehoy - Convert.ToInt32(cmbAnio.SelectedItem.ToString());
            }
            mesquecumple = Convert.ToInt32(cmbMes.SelectedIndex);
            diaquecumple = Convert.ToInt32(cmbDia.SelectedIndex);
            if (mesquecumple < mesdehoy)
            {
                if (diaquecumple < diadehoy)
                {
                    lblEdadFinal.Text = "Usted Tiene: " + Convert.ToString(aniofinal + 1) + " años";
                }
                else {
                    lblEdadFinal.Text = "Usted Tiene: " + Convert.ToString(aniofinal) + " años";
                }
            }
            else
            {
                lblEdadFinal.Text = "Usted Tiene: " + Convert.ToString(aniofinal) + " años";
            }      
        }
    }
}

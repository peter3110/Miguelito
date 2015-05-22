using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        string frase1 = "Yo vivo en Argentina";
        string frase2 = "Estoy hablando en Chino";
        string frase3 = "La wea fome";
        string frase4 = "El tiempo vale oro";
        string frase5 = "Santi no pierde tiempo";
        string fraseElegida;
        Random r = new Random();
        string resultado = "";

        public Form1()
        {
            InitializeComponent();

            int ant = 0;
            int x = r.Next(1, 6);

            for (int i = 1; i <= 5; i++)
            {

                if (x == 1)
                {
                    fraseElegida = frase1;
                }
                else
                {
                    if (x == 2)
                    {
                        fraseElegida = frase2;
                    }
                    else
                    {
                        if (x == 3)
                        {
                            fraseElegida = frase3;
                        }
                        else
                        {
                            if (x == 4)
                            {
                                fraseElegida = frase4;
                            }
                            else
                            {
                                if (x == 5)
                                {
                                    fraseElegida = frase5;
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < fraseElegida.Length; i++){
                if (fraseElegida.Substring(i, 1) == " "){
                    cmbItems.Items.Add(fraseElegida.Substring(ant, i - ant));
                    ant = i + 1;
                }
                if (i + 1 == fraseElegida.Length) {
                    i++;
                    cmbItems.Items.Add(fraseElegida.Substring(ant, i - ant));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra;
            if (cmbItems.SelectedIndex != -1){
                palabra = cmbItems.SelectedItem.ToString();
                cmbItems.Items.Remove(cmbItems.SelectedItem.ToString());
                if (resultado == ""){
                    resultado = palabra;
                }else{
                    resultado = resultado + " " + palabra;

                }
                lblResultado.Text = resultado;
                if (cmbItems.Items.Count == 0){
                    if (resultado == fraseElegida){
                        MessageBox.Show("Palabra bien puesta");
                    }else{
                        MessageBox.Show("Palabra mal puesta");
                    }
                }
            }else{
                MessageBox.Show("No seleccionaste nada");
            }
        }
    }
}

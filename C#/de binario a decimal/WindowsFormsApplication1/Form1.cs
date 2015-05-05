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
        int num, cantNum, i, pos, cambioPos = 1;
        string numbin;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHacer_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtBinario.Text);
            while (num == 1 || num == 0 || i > 0)
            {
                cantNum = txtBinario.Text.Length;
                while (cantNum > 1)
                {
                    numbin = txtBinario.Text.Substring(i, 1);
                    pos = i - cambioPos;
                    cambioPos++;
                    i++;
                }
            }
        }
    }
}

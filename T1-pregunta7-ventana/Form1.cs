using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_pregunta7_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int notafinal = int.Parse(txtb1.Text);

            if (notafinal >= 90 && notafinal <= 100)
            {
                lbl.Text = " A";
            }
            else if (notafinal >= 80 && notafinal <= 89)
            {
                lbl.Text = " B";
            }
            else if (notafinal >= 70 && notafinal <= 79)
            {
                lbl.Text = " C";
            }
            else if (notafinal >= 60 && notafinal <= 69)
            {
                lbl.Text = " D";
            }
            else
            {
                lbl.Text = " F";
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_program
{
    public partial class Form : System.Windows.Forms.Form
    {
        Button poga = new Button();

        public Form()
        {
            InitializeComponent();
            PogasIzveide(4);
        }

        public void PogasIzveide(int mainigais)
        {
            poga.BackColor = Color.Red;
            poga.Width = 50;
            poga.Height = 20;
            poga.Visible = true;
            poga.Location = new Point(185, 342);
            poga.Text = "Nospied!";
        }

    }
}

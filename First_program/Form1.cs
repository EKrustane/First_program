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
            PogasIzveide();
        }
        
        public void PogasIzveide()
        {
            //Pogas izskata apraksts
            this.Controls.Add(poga);
            poga.BackColor = Color.Red;
            poga.Width = 100;
            poga.Height = 50;
            poga.Visible = true;
            poga.Location = new Point(200, 350);
            poga.Text = "Nospied!";
            poga.Click += poga_Click;
        }

        private void poga_Click(object sender, EventArgs e)
        {
            kvadrats.BackColor = Color.Red;
        }

        
    }
}

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
        TextBox teksts = new TextBox();
        string krasa;

        public Form()
        {
            InitializeComponent();
            PogasIzveide();
            TekstlodzinaIzveide();
        }
        
        public void PogasIzveide()
        {
            //Pogas izskata apraksts
            this.Controls.Add(poga);
            poga.BackColor = Color.Red;
            poga.Width = 100;
            poga.Height = 50;
            poga.Visible = true;
            poga.Location = new Point(190, 370);
            poga.Text = "Nospied!";
            poga.Click += poga_Click;
        }
        public void TekstlodzinaIzveide()
        {
            //Tekstlodzina izskata apraksts
            this.Controls.Add(teksts);
            teksts.Width = 100;
            teksts.Height = 20;
            teksts.Visible = true;
            teksts.Location = new Point(190, 340);
            teksts.Enter += teksts_Enter;
        }

        private void teksts_Enter(object sender, EventArgs e)
        {
            krasa = teksts.Text;
        }

        private void poga_Click(object sender, EventArgs e)
        { 
            if (krasa.Equals("red"))
            {
                kvadrats.BackColor = Color.Red;
            }
            else if (krasa.Equals("blue"))
            {
                kvadrats.BackColor = Color.Blue;
            }
            else
            {
                kvadrats.BackColor = Color.Transparent;
            }
            
        }

    }
}

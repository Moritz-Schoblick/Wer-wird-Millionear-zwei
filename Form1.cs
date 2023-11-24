using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Wer_wird_Millionear_zwei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Boption_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {


          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.Transparent)
            {
                label24.Text = "Wie viele Kontinente gibt es auf der Erde?";
                label27.Text = "1";
                Aoption.Text = "A) 4";
                Boption.Text = "B) 33";
                Coption.Text = "C) 7";
                Doption.Text = "D) 3,9";
            }

            if (label27.Text == "1")
            {
                panel1.BackColor = Color.DarkOrange;
            }

            if (label27.Text == "2")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "3")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "4")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "5")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "6")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "7")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "8")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "9")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "10")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "11")
            {
                panel1.BackColor = Color.DarkOrange;
            }
            if (label27.Text == "12")
            {
                panel1.BackColor = Color.DarkOrange;
            }
        }

        private void Boption_Click(object sender,EventArgs e)
        {
            if(label27.Text=="1" || label27.Text==" 2" ||label27.Text=="3"|| label27.Text == "8" || label27.Text == "9" || label27.Text == "11" ||)
            {
                Boption.FillColor = Color.DarkGreen;
            }
            else
            {
                Boption.FillColor=Color.DarkRed
            }
        }
    }
     
}

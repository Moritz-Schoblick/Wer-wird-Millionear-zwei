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
using Microsoft.Win32.SafeHandles;

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
            label27.Text = "Ich bin sicher Option A ist richtig";
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            label27.Text = "Ich denke Antwort A oder B";
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
            if (panel1.BackColor == Color.Transparent) //option fill color anpassen C richtig
            {
                label24.Text = "Wie viele Kontinente gibt es auf der Erde?"; 
                label23.Text = "1";
                Aoption.Text = "A) 4";
                Boption.Text = "B) 33";
                Coption.Text = "C) 7";
                Doption.Text = "D) 3,9";
            }
            if (panel1.BackColor == Color.DarkOrange) //option fill color anpassen
            {
                label24.Text = "Was schrieb Karl Marx?";
                label23.Text = "2";
                Aoption.Text = "A) Maerchen";
                Boption.Text = "B) Kommunistisches Manifest";
                Coption.Text = "C) Liebesromane";
                Doption.Text = "D) Broschüren";
                Boption.FillColor = Color.DarkSlateGray;
            }

            if (panel2.BackColor == Color.DarkOrange)
            {
                label24.Text = "Wofür ist der Ort Verdun in Frankreich bekannt?";
                label23.Text = "3";
                Aoption.Text = "A) Verdun befindet sich in einer Wüste";
                Boption.Text = "B) Großer Schauplatz im ersten Weltkrieg";
                Coption.Text = "C) Die größten Menschen der Welt kommen aus Verdun";
                Doption.Text = "D) Für seine historische Altstadt";
                Boption.FillColor = Color.DarkSlateGray;
            }

            if (panel3.BackColor == Color.DarkOrange)  //option fill color anpassen,frage hinzufügen
            {
                label24.Text = "Wofür ist der Ort Verdun in Frankreich bekannt?";
                label23.Text = "4";
                Aoption.Text = "A) Verdun befindet sich in einer Wüste";
                Boption.Text = "B) Großer Schauplatz im ersten Weltkrieg";
                Coption.Text = "C) Die größten Menschen der Welt kommen aus Verdun";
                Doption.Text = "D) Für seine historische Altstadt";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel4.BackColor == Color.DarkOrange)  //option fill color anpassen,frage hinzufügen
            {
                label24.Text = "Wofür ist der Ort Verdun in Frankreich bekannt?";
                label23.Text = "5";
                Aoption.Text = "A) Verdun befindet sich in einer Wüste";
                Boption.Text = "B) Großer Schauplatz im ersten Weltkrieg";
                Coption.Text = "C) Die größten Menschen der Welt kommen aus Verdun";
                Doption.Text = "D) Für seine historische Altstadt";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel5.BackColor == Color.DarkOrange)  //option fill color anpassen,frage hinzufügen
            {
                label24.Text = "Wofür ist der Ort Verdun in Frankreich bekannt?";
                label23.Text = "6";
                Aoption.Text = "A) Verdun befindet sich in einer Wüste";
                Boption.Text = "B) Großer Schauplatz im ersten Weltkrieg";
                Coption.Text = "C) Die größten Menschen der Welt kommen aus Verdun";
                Doption.Text = "D) Für seine historische Altstadt";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel6.BackColor == Color.DarkOrange)  //option fill color anpassen,frage hinzufügen
            {
                label24.Text = "Wofür ist der Ort Verdun in Frankreich bekannt?";
                label23.Text = "7";
                Aoption.Text = "A) Verdun befindet sich in einer Wüste";
                Boption.Text = "B) Großer Schauplatz im ersten Weltkrieg";
                Coption.Text = "C) Die größten Menschen der Welt kommen aus Verdun";
                Doption.Text = "D) Für seine historische Altstadt";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel7.BackColor == Color.DarkOrange)  //option fill color anpassen,frage hinzufügen
            {
                label24.Text = "Wofür ist der Ort Verdun in Frankreich bekannt?";
                label23.Text = "8";
                Aoption.Text = "A) Verdun befindet sich in einer Wüste";
                Boption.Text = "B) Großer Schauplatz im ersten Weltkrieg";
                Coption.Text = "C) Die größten Menschen der Welt kommen aus Verdun";
                Doption.Text = "D) Für seine historische Altstadt";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel8.BackColor == Color.DarkOrange)  //option fill color anpassen,frage hinzufügen
            {
                label24.Text = "Wofür ist der Ort Verdun in Frankreich bekannt?";
                label23.Text = "9";
                Aoption.Text = "A) Verdun befindet sich in einer Wüste";
                Boption.Text = "B) Großer Schauplatz im ersten Weltkrieg";
                Coption.Text = "C) Die größten Menschen der Welt kommen aus Verdun";
                Doption.Text = "D) Für seine historische Altstadt";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel9.BackColor == Color.DarkOrange)  //option fill color anpassen,frage hinzufügen
            {
                label24.Text = "Wofür ist der Ort Verdun in Frankreich bekannt?";
                label23.Text = "10";
                Aoption.Text = "A) Verdun befindet sich in einer Wüste";
                Boption.Text = "B) Großer Schauplatz im ersten Weltkrieg";
                Coption.Text = "C) Die größten Menschen der Welt kommen aus Verdun";
                Doption.Text = "D) Für seine historische Altstadt";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (label23.Text == "1")
            {
                panel1.BackColor = Color.DarkOrange;
            }

            if (label23.Text == "2")
            {
                panel2.BackColor = Color.DarkOrange;
                panel1.BackColor = Color.Transparent;
            }
            if (label23.Text == "3")
            {
                panel3.BackColor = Color.DarkOrange;
                panel2.BackColor = Color.Transparent;
            }
            if (label23.Text == "4")
            {
                panel4.BackColor = Color.DarkOrange;
                panel3.BackColor = Color.Transparent;
            }
            if (label23.Text == "5")
            {
                panel5.BackColor = Color.DarkOrange;
                panel4.BackColor = Color.Transparent;
            }
            if (label23.Text == "6")
            {
                panel6.BackColor = Color.DarkOrange;
                panel5.BackColor = Color.Transparent;
            }
            if (label23.Text == "7")
            {
                panel7.BackColor = Color.DarkOrange;
                panel6.BackColor = Color.Transparent;
            }
            if (label23.Text == "8")
            {
                panel8.BackColor = Color.DarkOrange;
                panel7.BackColor = Color.Transparent;
            }
            if (label23.Text == "9")
            {
                panel9.BackColor = Color.DarkOrange;
                panel8.BackColor = Color.Transparent;
            }
            if (label23.Text == "10")
            {
                panel10.BackColor = Color.DarkOrange;
                panel9.BackColor = Color.Transparent;
            }
            
        }

        private void Boption_Click_1(object sender, EventArgs e)
        {
            if(label23.Text=="2" ||label23.Text=="3")
            {
                Boption.FillColor = Color.DarkGreen;
            }
            else
            {
                Boption.FillColor = Color.DarkRed;
                MessageBox.Show("Falsche Antwort, Verloren");
            }
        }
        private void Aoption_Click(object sender, EventArgs e)
        {
            if (label23.Text=="4" || label23.Text=="5")
            {
                Aoption.FillColor = Color.DarkGreen;
            }
            else
            {
                Boption.FillColor = Color.DarkRed;
                MessageBox.Show("Falsche Antwort, Verloren");
            }

        }

        private void Coption_Click(object sender, EventArgs e)
        {
            if(label23.Text=="1"||label23.Text=="6"||label23.Text=="8" ||label23.Text=="9")
            {
                Coption.FillColor = Color.DarkGreen;

            }
            else
            {
                Coption.FillColor = Color.DarkRed;
                MessageBox.Show("Falsche Antwort, Verloren");
            }
        }

        private void Doption_Click(object sender, EventArgs e)
        {
            if (label23.Text=="10"|| label23.Text=="7")
            {
                Doption.FillColor = Color.DarkGreen;
            }
            else
            {
                Doption.FillColor = Color.DarkRed;
                MessageBox.Show("Falsche Antwort, Verloren");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label27.Text = "Keine Ahnung";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelPhone.Visible = true;
        }

        private void label25_Click(object sender, EventArgs e)
        {
            panelPhone.Visible = false;
            pictureBox1.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 65;
            progressBar2.Value = 20;
            progressBar3.Value = 5;
            progressBar4.Value = 10;
            label32.Text = "65%";
            label33.Text = "20%";
            label34.Text = "5%";
            label35.Text = "10%";
        }

        private void label26_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            pictureBox2.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Aoption.Text = "";
            Boption.Text = "";
            pictureBox3.Visible = false;
        }
    }
     
}
//label 27 = 23, label 28 = 24
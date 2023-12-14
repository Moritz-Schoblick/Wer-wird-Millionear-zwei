using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wer_wird_Millionear_zwei
{
    public partial class Form1 : Form
    {

        string correctAnswer;
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
            label27.Text = "Ich bin sicher Option A ist richtig";           //Telefon Antwort
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            label27.Text = "Ich denke Antwort A oder B";                    //Telefon Antwort      
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
            Aoption.FillColor = Color.DarkSlateGray;
            Boption.FillColor = Color.DarkSlateGray;
            Coption.FillColor = Color.DarkSlateGray;
            Doption.FillColor = Color.DarkSlateGray;
            label36.Visible = false;
            if (panel1.BackColor == Color.Transparent) 
            {
                label24.Text = "Wie viele Kontinente gibt es auf der Erde?";    //Frage definieren
                label23.Text = "1";                                             //Fragen Nummer
                Aoption.Text = "A) 4";                                          
                Boption.Text = "B) 33";
                Coption.Text = "C) 7";                                          //Richtige Antwort
                Doption.Text = "D) 3,9";
                correctAnswer = "C";
            }
            if (panel1.BackColor == Color.DarkOrange)
            {
                label24.Text = "Was schrieb Karl Marx?";                        //Frage definieren
                label23.Text = "2";                                             //Fragen Nummer
                Aoption.Text = "A) Maerchen";
                Boption.Text = "B) Kommunistisches Manifest";                   //Richtige Antwort
                Coption.Text = "C) Liebesromane";
                Doption.Text = "D) Broschüren";
                correctAnswer = "B";
                Boption.FillColor = Color.DarkSlateGray;
            }

            if (panel2.BackColor == Color.DarkOrange)
            {
                label24.Text = "Wofür ist der Ort Verdun in Frankreich bekannt?";   //Frage definieren
                label23.Text = "3";                                                 //Fragen Nummer
                Aoption.Text = "A) Verdun befindet sich in einer Wüste";
                Boption.Text = "B) Großer Schauplatz im ersten Weltkrieg";          //Richtige Antwort
                Coption.Text = "C) Die größten Menschen der Welt kommen aus Verdun";
                Doption.Text = "D) Für seine historische Altstadt";
                correctAnswer = "B";
                Boption.FillColor = Color.DarkSlateGray;
            }

            if (panel3.BackColor == Color.DarkOrange)  
            {
                label24.Text = "Welches ist das chemische Symbol für Gold?";        //Frage definieren 
                label23.Text = "4";                                                 //Fragen Nummer
                Aoption.Text = "A) AU";                                             //Richtige Antwort
                Boption.Text = "B) Kg";
                Coption.Text = "C) Gg";
                Doption.Text = "D) Fr";
                correctAnswer = "A";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel4.BackColor == Color.DarkOrange)  
            {
                label24.Text = "Welches ist das älteste noch existierende Weltwunder der Antike?";  //Frage definieren
                label23.Text = "5";                                                                 //Fragen Nummer
                Aoption.Text = "A) Pyramiden von Gizeh";                                            //Richtige Antwort
                Boption.Text = "B) Zeusstatue des Phidias in Olympia";
                Coption.Text = "C) Artemistempel in Ephesos";
                Doption.Text = "D) Hängende Gärten von Babylon";
                correctAnswer = "A";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel5.BackColor == Color.DarkOrange)  
            {
                label24.Text = "Welcher Chemiker entdeckte das Element Radium und Polonium und prägte den Begriff \"Radioaktivität\"?";     //Frage definieren
                label23.Text = "6";                                                                                                         //Fragen Nummer
                Aoption.Text = "A) Antoine Lavoisier";                                                                                
                Boption.Text = "B) Pascal Foeert";
                Coption.Text = "C) Marie Curie ";                                                                                           //Richtige Antwort
                Doption.Text = "D) Ernest Rutherford";
                correctAnswer = "C";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel6.BackColor == Color.DarkOrange)  
            {
                label24.Text = "Welcher dieser Städte ist keine Hauptstadt?\r\n\r\n";       //Frage definieren
                label23.Text = "7";                                                         //Fragen Nummer
                Aoption.Text = "A) Kabul";                                              
                Boption.Text = "B) Jamestown";
                Coption.Text = "C) Montevideo";
                Doption.Text = "D) Iasi";                                                   //Richtige Antwort
                correctAnswer = "D";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel7.BackColor == Color.DarkOrange)  
            {
                label24.Text = "Welches ist das am häufigsten vorkommende Gas in der Atmosphäre des Mars?";     //Frage definieren
                label23.Text = "8";                                                                             //Fragen Nummer
                Aoption.Text = "A) Stickstoff";                                                               
                Boption.Text = "B) Sauerstoff";
                Coption.Text = "C) Kohlendioxid";                                                               //Richtige Antwort
                Doption.Text = "D) Methan";
                correctAnswer = "C";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel8.BackColor == Color.DarkOrange)  
            {
                label24.Text = "Welcher britische Philosoph und Ökonom verfasste das Werk \"An Inquiry into the Nature and Causes of the Wealth of Nations?";       //Frage definieren
                label23.Text = "9";                                                                                                                                 //Fragen Nummer
                Aoption.Text = "A) John Locke";
                Boption.Text = "B) David Hume";
                Coption.Text = "C) Adam Smith";                                                                                                                     //Richtige Antwort
                Doption.Text = "D) Karl Marx";
                correctAnswer = "C";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (panel9.BackColor == Color.DarkOrange)  
            {
                label24.Text = "Wie viel Prozent der Maenlichen Bevölkerung von Paraguay starben im Tripel-Allianz-Krieg von 1864 bis 1870?";       //Frage definieren
                label23.Text = "10";                                                                                                                //Fragen Nummer
                Aoption.Text = "A) 62%";
                Boption.Text = "B) 74%";
                Coption.Text = "C) 67%";
                Doption.Text = "D) 70%";                                                                                                            //Richtige Antwort
                correctAnswer = "D";
                Doption.FillColor = Color.DarkSlateGray;
            }

            if (label23.Text == "1")                        //Fragen fortschritt
            {
                panel1.BackColor = Color.DarkOrange;
            }

            if (label23.Text == "2")                        //Fragen fortschritt
            {
                panel2.BackColor = Color.DarkOrange;
                panel1.BackColor = Color.Transparent;
            }
            if (label23.Text == "3")                        //Fragen fortschritt
            {
                panel3.BackColor = Color.DarkOrange;
                panel2.BackColor = Color.Transparent;
            }
            if (label23.Text == "4")                        //Fragen fortschritt
            {
                panel4.BackColor = Color.DarkOrange;
                panel3.BackColor = Color.Transparent;
            }
            if (label23.Text == "5")                        //Fragen fortschritt 
            {
                panel5.BackColor = Color.DarkOrange;
                panel4.BackColor = Color.Transparent;
            }
            if (label23.Text == "6")                        //Fragen fortschritt
            {
                panel6.BackColor = Color.DarkOrange;
                panel5.BackColor = Color.Transparent;
            }
            if (label23.Text == "7")                        //Fragen fortschritt
            {
                panel7.BackColor = Color.DarkOrange;
                panel6.BackColor = Color.Transparent;
            }
            if (label23.Text == "8")                        //Fragen fortschritt
            {
                panel8.BackColor = Color.DarkOrange;
                panel7.BackColor = Color.Transparent;
            }
            if (label23.Text == "9")                        //Fragen fortschritt
            {
                panel9.BackColor = Color.DarkOrange;
                panel8.BackColor = Color.Transparent;
            }
            if (label23.Text == "10")                       //Fragen fortschritt
            {
                panel10.BackColor = Color.DarkOrange;
                panel9.BackColor = Color.Transparent;
            }
            
        }

        private void Boption_Click_1(object sender, EventArgs e)
        {
            if(label23.Text=="2" ||label23.Text=="3")                                       //Richtige Antwort Bestimmen, Frage 2,3
            {
                Boption.FillColor = Color.DarkGreen;
                MessageBox.Show("Richtige Antwort, zum Fortfahren LOG drücken");            //Ereignis für richtige Antwort
            }
            else
            {
                Boption.FillColor = Color.DarkRed;                                         
                MessageBox.Show("Falsche Antwort, Verloren. Beenden Sie das Spiel.");       //Ereignis für Falsche Antwort
            }
        }
        private void Aoption_Click(object sender, EventArgs e)
        {
            if (label23.Text=="4" || label23.Text=="5")                                     //Richtige Antwort Bestimmen, Frage 4,5
            {
                Aoption.FillColor = Color.DarkGreen;
                MessageBox.Show("Richtige Antwort, zum Fortfahren LOG drücken");            //Ereignis für richtige Antwort
            }
            else
            {
                Boption.FillColor = Color.DarkRed;
                MessageBox.Show("Falsche Antwort, Verloren. Beenden Sie das Spiel.");       //Ereignis für Falsche Antwort
            }

        }

        private void Coption_Click(object sender, EventArgs e)
        {
            if(label23.Text=="1"||label23.Text=="6"||label23.Text=="8" ||label23.Text=="9") //Richtige Antwort Bestimmen, Frage 1,6,8,9
            {
                Coption.FillColor = Color.DarkGreen;
                MessageBox.Show("Richtige Antwort, zum Fortfahren LOG drücken");            //Ereignis für richtige Antwort
            }
            else
            {
                Coption.FillColor = Color.DarkRed;
                MessageBox.Show("Falsche Antwort, Verloren. Beenden Sie das Spiel.");       //Ereignis für Falsche Antwort
            }
        }

        private void Doption_Click(object sender, EventArgs e)
        {
            if (label23.Text=="10"|| label23.Text=="7")                                     //Richtige Antwort Bestimmen, Frage 7,10
            {
                Doption.FillColor = Color.DarkGreen;
                MessageBox.Show("Richtige Antwort, zum Fortfahren LOG drücken");            //Ereignis für richtige Antwort
            }
            else
            {
                Doption.FillColor = Color.DarkRed;
                MessageBox.Show("Falsche Antwort, Verloren. Beenden Sie das Spiel.");       //Ereignis für Falsche Antwort
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label27.Text = "Keine Ahnung";                                                  //Telefon Antwort
        }

        private void pictureBox1_Click(object sender, EventArgs e)                          //Telefon Joker wählen
        {
            panelPhone.Visible = true;
        }

        private void label25_Click(object sender, EventArgs e)                              // Joker Verlassen
        {
            panelPhone.Visible = false;
            pictureBox1.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)                         //Umfrage Joker

        {
            if (correctAnswer == "C")                                                       //Ergebnis bei C Korrekt
            {
                progressBar1.Value = 5;
                progressBar2.Value = 20;
                progressBar3.Value = 65;
                progressBar4.Value = 10;
                label32.Text = "5%";
                label33.Text = "20%";
                label34.Text = "65%";
                label35.Text = "10%";
            }

            if (correctAnswer == "B")                                                       //Ergebnis bei B Korrekt
            {
                progressBar1.Value = 5;
                progressBar2.Value = 50;
                progressBar3.Value = 15;
                progressBar4.Value = 30;
                label32.Text = "5%";
                label33.Text = "50%";
                label34.Text = "15%";
                label35.Text = "30%";
            }

            if (correctAnswer == "A")                                                       //Ergebnis bei A Korrekt
            {
                progressBar1.Value = 42;
                progressBar2.Value = 20;
                progressBar3.Value = 19;
                progressBar4.Value = 19;
                label32.Text = "42%";
                label33.Text = "20%";
                label34.Text = "19%";
                label35.Text = "19%";
            }

            if (correctAnswer == "D")                                                       //Ergebnis bei D Korrekt
            {
                progressBar1.Value = 17;
                progressBar2.Value = 24;
                progressBar3.Value = 21;
                progressBar4.Value = 38;
                label32.Text = "17%";
                label33.Text = "24%";
                label34.Text = "21%";
                label35.Text = "38%";
            }

        }


private void label26_Click(object sender, EventArgs e)                                      // Joker Verlassen
        {
            panel11.Visible = false;
            pictureBox2.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)                          // Umfrage Joker wählen
        {
            panel11.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)                          // 50/50 Joker wählen
        {
            Aoption.Text = "";
            Boption.Text = "";
            pictureBox3.Visible = false;
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)                              // Spiel schliessen
        {
            Close();
        }
    }
     
}
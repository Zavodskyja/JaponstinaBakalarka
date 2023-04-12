using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Japonstina.vyuka;

namespace Japonstina
{

    public partial class Vyuka : Form
    {/* 
        private int ChybaPocet;

        private bool OdpovedNeuspesna;
        */
        string Cesky { get; set; }

        public string JpZnak { get; set; }

        string Abeceda { get; set; }

        





        public Vyuka()
        {

            InitializeComponent();

            VyukaMain();




        }
        
        public void VyukaMain()
        {
            var slovnik = JP.Slovnik();
            var random = new Random();
            var SeznamZnaku = slovnik.Where(i => i.Key.znaky == abeceda.Katakana || i.Key.znaky == abeceda.Hiragana).OrderBy(x => random.Next()).Select(x => x.Key.ID).Take(4).ToList();
            var RandomJpZnaku = SeznamZnaku[random.Next(SeznamZnaku.Count)];
            var Znak = slovnik.FirstOrDefault(i => i.Key.ID == RandomJpZnaku);
            JpZnak = Znak.Value.JP;
            Cesky = Znak.Value.CZ;
            znak.Text = JpZnak;
            var Preklad = slovnik.Where(i => SeznamZnaku.Contains(i.Key.ID)).Select(x => x.Value.CZ).ToList();
            var PrekladRandom = Preklad.OrderBy(a => random.Next()).ToList();
            /*Pridat list a foreach? .. sjednotit pod jednu funkci vsechny buttony */
            Hiragana_button1.Text = PrekladRandom[0].ToString();
            button2.Text = PrekladRandom[1].ToString();
            button3.Text = PrekladRandom[2].ToString();
            button4.Text = PrekladRandom[3].ToString();
            Hiragana_button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            Hiragana_button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            label1.Text = "";

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            /*
            if (OdpovedNeuspesna==true)
            {
                ChybaPocet = 0;
                VyukaMain();
                OdpovedNeuspesna = false;
                StavOdpovedi.Text = "";
                PocetChyb.Text="";
                SpravnaOdpoved.Text = "";
                OdpovedBox.Clear();
                button1.Text = "Potvrdit";  

                
            }
            else if (OdpovedBox.Text != CzPrepis)
            {
                StavOdpovedi.Text = "Chyba";
                ChybaPocet++;
                PocetChyb.Text = ChybaPocet.ToString() + "/3";
                OdpovedBox.Clear();
                if (ChybaPocet == 3)
                {
                    SpravnaOdpoved.Text = "Správná odpověď:" + CzPrepis;
                    button1.Text = "Další";
                    OdpovedNeuspesna = true;
                }

                ProgressManager.UpdateProgress(ZnakId, ChybaPocet);
            }
            else
            {
                ChybaPocet = 0;
                StavOdpovedi.Text = "";
                PocetChyb.Text = "";
                button1.Text = "Potvrdit";
                OdpovedBox.Clear();
                VyukaMain();
                ProgressManager.UpdateProgress(ZnakId, ChybaPocet);

            
            }
            */
        }

        private void znak_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PocetChyb_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            

            if (Hiragana_button1.Text == Cesky)
            {
                
                Hiragana_button1.BackColor = Color.Green;
                Hiragana_button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                await Task.Delay(1000);
                VyukaMain();


            }
            else
            {
                Hiragana_button1.BackColor = Color.FromArgb(188, 0, 45);
                Hiragana_button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                label1.Text = Cesky;
                await Task.Delay(2000);
                VyukaMain();
            }
            

            

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == Cesky)
            {
                button2.BackColor = Color.Green;
                Hiragana_button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                await Task.Delay(1000);
                VyukaMain();


            }
            else
            {
                button2.BackColor = Color.FromArgb(188, 0, 45);
                Hiragana_button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                label1.Text = Cesky;
                await Task.Delay(2000);
                VyukaMain();
            }
            

            

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == Cesky)
            {
                button3.BackColor = Color.Green;
                Hiragana_button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                await Task.Delay(1000);
                VyukaMain();


            }
            else
            {
                button3.BackColor = Color.FromArgb(188, 0, 45);
                Hiragana_button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                label1.Text = Cesky;
                await Task.Delay(2000);
                VyukaMain();
            }
            

            

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == Cesky)
            {
                button4.BackColor = Color.Green;
                Hiragana_button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                await Task.Delay(1000);
                VyukaMain();


            }
            else
            {
                button4.BackColor = Color.FromArgb(188, 0, 45);
                Hiragana_button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                label1.Text = Cesky;
                await Task.Delay(2000);
                VyukaMain();
            }
           

            

        }
    }
}

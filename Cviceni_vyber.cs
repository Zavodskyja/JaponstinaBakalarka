using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japonstina.models;



namespace Japonstina
{
    public partial class Cviceni_vyber : Form
    {
        public Cviceni_vyber()
        {
            InitializeComponent();
        }

        public bool Hiragana;
        public bool Katakana;
        public bool N5;
        public bool N4;
        public bool Ichidan;
        public bool Godan;
        public bool Irregular;



        private void button1_Click(object sender, EventArgs e)
        {
            if (StavAplikace.ActiveForm != "HiraganaKatakana")
            {
                Program.welcome.panel1.Controls.Clear();
                Vyuka v = new Vyuka();
                v.TopLevel = false;
                Program.welcome.panel1.Controls.Add(v);
                v.Dock = DockStyle.Fill;
                v.Show();
                StavAplikace.ActiveForm = "HiraganaKatakana";
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StavAplikace.ActiveForm != "Kanji")  /*account.HiraganaProgress == 100 && account.KatakanaProgress == 100  doplnit podminky na splneni H+K pred vyukou kanji */
            {
                Program.welcome.panel1.Controls.Clear();
                VyukaKanji k = new VyukaKanji();
                k.TopLevel = false;
                Program.welcome.panel1.Controls.Add(k);
                k.Dock = DockStyle.Fill;
                k.Show();
                StavAplikace.ActiveForm = "Kanji";
            }
            else
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

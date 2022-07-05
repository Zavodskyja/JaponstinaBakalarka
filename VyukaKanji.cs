using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japonstina.kanji;

namespace Japonstina
{
    public partial class VyukaKanji : Form
    {


        
        public int ZnakId { get; set; }


        string Kanji { get; set; }

        string Furigana { get; set; }

        string Cesky { get; set; }


        public VyukaKanji()
        {
            InitializeComponent();
            KanjiMain();
        }

        private void Kanji_Load(object sender, EventArgs e)
        {




        }

        public void KanjiMain()

        {
            var slovnik = kanji.Kanji.Slovnik();
            var random = new Random();
            var SeznamZnaku = slovnik.Where(i => i.Key.Uroven == JLPT.N5 || i.Key.Uroven == JLPT.N4).OrderBy(x => random.Next()).Select(x => x.Key.ID).Take(4).ToList(); /*22.6. Predelat dle hiragany pro vetsi seznamy*/
            var RandomKanji = SeznamZnaku[random.Next(SeznamZnaku.Count)]; /*TODO: Dodelat plneni tlacitek*/
            var KanjiZnak = slovnik.FirstOrDefault(i => i.Key.ID == RandomKanji);
            Kanji = KanjiZnak.Value.Kanji;
            Furigana = KanjiZnak.Value.JP;
            Cesky = KanjiZnak.Value.CZ;
            var Preklad = slovnik.Where(i => SeznamZnaku.Contains(i.Key.ID)).Select(x => x.Value.CZ).ToList();
            var PrekladRandom = Preklad.OrderBy(a => random.Next()).ToList();
            /*Tlacitka - Zatim nastrel funkcionality*/
            kanji_button1.Text = PrekladRandom[0].ToString();
            kanji_button2.Text = PrekladRandom[1].ToString();
            kanji_button3.Text = PrekladRandom[2].ToString();
            kanji_button4.Text = PrekladRandom[3].ToString();





            /* --Zjednodusit
            Dodelat funkci na tlacitka a posialt do ni pouze objekt daneho tlaticka ( button1, button2 atd.)
            */


            if (String.IsNullOrEmpty(Kanji))
             {
                 kanji_char.Text = Furigana;
                 kanji_hiragana.Text = "";
             }
             else
             {
                 kanji_char.Text = Kanji;
                 kanji_hiragana.Text = Furigana;
             }

            



        }
       

            private void kanji_char_Click(object sender, EventArgs e)
        {

        }

        private void kanji_hiragana_Click(object sender, EventArgs e)
        {
            /*TODO Dodelat funkci tlacitek --  naplnit list 3+1 , shuffle , priradit tlacitkum*/
        }

        private void kanji_button1_Click(object sender, EventArgs e)
        {
            if (kanji_button1.Text == Cesky)
            {
                kanji_button1.BackColor = Color.White;
               
            }
            else
            {
                kanji_button1.BackColor = Color.Black;
            }

        }

        private void kanji_button2_Click(object sender, EventArgs e)
        {
            if(kanji_button2.Text == Cesky)
            {
                kanji_button2.BackColor = Color.White;
                
            }
            else
            {
                kanji_button2.BackColor = Color.Black;
            }
        }

        private void kanji_button3_Click(object sender, EventArgs e)
        {
            if (kanji_button3.Text == Cesky)
            {
                kanji_button3.BackColor = Color.White;
               
            }
            else
            {
                kanji_button3.BackColor = Color.Black;
            }

        }

        private void kanji_button4_Click(object sender, EventArgs e)
        {
            if (kanji_button4.Text == Cesky)
            {
                kanji_button4.BackColor = Color.White;
                
            }
            else
            {
                kanji_button4.BackColor = Color.Black;
            }

        }


    }
}

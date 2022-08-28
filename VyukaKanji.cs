using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japonstina.vyuka;
using Japonstina.models;



namespace Japonstina
{
    public partial class VyukaKanji : Form
    {



        public int ZnakId { get; set; }

        string Kanji { get; set; }

        string Furigana { get; set; }

        string Cesky { get; set; }

        List<String> Selected { get; set; }

        int test = 0;

       





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

            KanjiRandomFunkce();
            testhasd();






        }

       

            private void kanji_char_Click(object sender, EventArgs e)
        {

        }

        private void kanji_hiragana_Click(object sender, EventArgs e)
        {
            /*TODO Dodelat funkci tlacitek --  naplnit list 3+1 , shuffle , priradit tlacitkum*/
        }

        private async void kanji_button1_Click(object sender, EventArgs e)
        {
            if (Vyuka_button1.Text == Cesky)
            {
                ButtonColorCorrect(Vyuka_button1);
                ButtonDisable();
                await Task.Delay(1000);
                KanjiMain();

            }
            else
            {
                ButtonColorIncorrect(Vyuka_button1);
                ButtonDisable();
                label1.Text = Cesky;
                await Task.Delay(2000);
                KanjiMain();
            }

        }

        private async void kanji_button2_Click(object sender, EventArgs e)
        {
            if(Vyuka_button2.Text == Cesky)
            {
                ButtonColorCorrect(Vyuka_button2);
                ButtonDisable();
                await Task.Delay(1000);
                KanjiMain();

            }
            else
            {
                ButtonColorIncorrect(Vyuka_button2);
                ButtonDisable();
                label1.Text = Cesky;
                await Task.Delay(2000);
                KanjiMain();
            }
        }

        private async void kanji_button3_Click(object sender, EventArgs e)
        {
            if (Vyuka_button3.Text == Cesky)
            {
                ButtonColorCorrect(Vyuka_button3);
                ButtonDisable();
                await Task.Delay(1000);
                KanjiMain();

            }
            else
            {
                ButtonColorIncorrect(Vyuka_button3);
                ButtonDisable();    
                label1.Text = Cesky;
                await Task.Delay(2000);
                KanjiMain();
            }

        }

        private async void kanji_button4_Click(object sender, EventArgs e)
        {
            if (Vyuka_button4.Text == Cesky)
            {
                
                ButtonColorCorrect(Vyuka_button4);
                ButtonDisable();
                await Task.Delay(1000);
                KanjiMain();

            }
            else
            {
                ButtonColorIncorrect(Vyuka_button4);
                ButtonDisable();
                label1.Text = Cesky;
                await Task.Delay(2000);
                KanjiMain();
            }

        }

        

        public void KanjiRandomFunkce()
        {

            testhasd();
            var slovnik = ProgressManager.KanjiLoadData.Data;
            var random = new Random();
            var SeznamZnaku = slovnik.Where(i => i.KanjiUroven == "N5" || i.KanjiUroven == "N4").OrderBy(x => random.Next()).Select(x => x.KanjiId).Take(4).ToList();
            var RandomKanji = SeznamZnaku[random.Next(SeznamZnaku.Count)]; 
            var KanjiZnak = slovnik.FirstOrDefault(i => i.KanjiId == RandomKanji);
            Kanji = KanjiZnak.KanjiZnak;
            Furigana = KanjiZnak.KanjiJp;
            Cesky = KanjiZnak.KanjiCZ;
            var Preklad = slovnik.Where(i => SeznamZnaku.Contains(i.KanjiId)).Select(x => x.KanjiCZ).ToList();
            var PrekladRandom = Preklad.OrderBy(a => random.Next()).ToList();
            ButtonText(PrekladRandom);
            ButtonDefault();
            label1.Text = "";
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
        /*Predelani na sdilenou komponentu .. jen posilat co se ma selectit a funkce bude sdilena..napr. Typ = 1 hiragana, 2 kanji, 3 slovesa..pripadne poslat array vybranych */
        public void RandomZnak(int typ)
        {
            typ = 0;
            var slovnikKanji = ProgressManager.KanjiLoadData.Data;
            var slovnikHiragana = JP.Slovnik();
            var random = new Random();
            /*Rozdělení do solo funkce .. WIP
             * 
             * 
             * 
            var Selected = Cviceni_vyber.CheckBoxSelected;
            var WordList = slovnikKanji.Where(i => Selected.Contains(i.KanjiUroven)).OrderBy(x => random.Next()).Select(x => x.KanjiId).Take(4).ToList();
             */
            var SeznamZnaku = slovnikKanji.Where(i => i.KanjiUroven == "N5" || i.KanjiUroven == "N4").OrderBy(x => random.Next()).Select(x => x.KanjiId).Take(4).ToList();
            var RandomKanji = SeznamZnaku[random.Next(SeznamZnaku.Count)];
            var KanjiZnak = slovnikKanji.FirstOrDefault(i => i.KanjiId == RandomKanji);
            Kanji = KanjiZnak.KanjiZnak;
            Furigana = KanjiZnak.KanjiJp;
            Cesky = KanjiZnak.KanjiCZ;
            var Preklad = slovnikKanji.Where(i => SeznamZnaku.Contains(i.KanjiId)).Select(x => x.KanjiCZ).ToList();
            var PrekladRandom = Preklad.OrderBy(a => random.Next()).ToList();
            ButtonText(PrekladRandom);
            ButtonDefault();
            label1.Text = "";
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




        public void ButtonDisable()
        {
            foreach (Control c in panel1.Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = false;
                }
            }

        }

        public void ButtonText(List<string> test)
        {

            Button[] buttons = { Vyuka_button1, Vyuka_button2, Vyuka_button3, Vyuka_button4 };
            for (int i = 0; i < buttons.Count(); i++)
                buttons[i].Text = test[i];
            }


        public void ButtonDefault()
        {
            foreach (Control c in panel1.Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.BackColor = Color.White;
                    b.Enabled = true;
                    
                }
            }


        }

        public void ButtonColorCorrect(Button button)
        {
            button.BackColor = Color.Green;
        }

        public void ButtonColorIncorrect(Button button)
        {
            button.BackColor = Color.FromArgb(188, 0, 45);
        }

        public void VyukaTest() /*Zatim test*/
        {
            if(VyberCviceni.btn == "Abecedy")
            {
                if (VyberCviceni.Hiragana == true && VyberCviceni.Katakana ==true)
                {

                }


            }
            else if (VyberCviceni.btn == "Kanji")
            {
                if (VyberCviceni.N5 == true && VyberCviceni.N4 == true)
                {
                    test = 1;
                }
                if (VyberCviceni.N5 == true && VyberCviceni.N4 == false)
                {
                    test = 2;
                }
                if (VyberCviceni.N5 == false && VyberCviceni.N4 == true)
                {
                    test = 3;
                }
                else
                {
                    test = 4;
                }


            }
            else if (VyberCviceni.btn == "Slovesa")
            {

            }
          
        }


    }
}

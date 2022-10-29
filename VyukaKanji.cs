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
using System.Reflection;
using System.Collections;
using System.Collections.Specialized;





namespace Japonstina
{
    public partial class VyukaKanji : Form
    {



        public int ZnakId { get; set; }

        string Kanji { get; set; }

        string Furigana { get; set; }

        string Cesky { get; set; }

        string Testa { get; set; }

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

            /*KanjiRandomFunkce();*/
            RandomZnak();








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
            if (Vyuka_button2.Text == Cesky)
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


            var slovnik = ProgressManager.KanjiLoadData.Data;
            var random = new Random();
            var SeznamZnaku = slovnik.Where(i => i.KanjiUroven == "N5" || i.KanjiUroven == "N4").OrderBy(x => random.Next()).Select(x => x.Id).Take(4).ToList();
            var RandomKanji = SeznamZnaku[random.Next(SeznamZnaku.Count)];
            var KanjiZnak = slovnik.FirstOrDefault(i => i.Id == RandomKanji);
            Kanji = KanjiZnak.KanjiZnak;
            Furigana = KanjiZnak.KanjiJp;
            Cesky = KanjiZnak.KanjiCZ;
            var Preklad = slovnik.Where(i => SeznamZnaku.Contains(i.Id)).Select(x => x.KanjiCZ).ToList();
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

        public void RandomZnak()
        {


            var slovnikKanji = ProgressManager.KanjiLoadData.Data;
            var slovnikHiragana = JP.Slovnik();
            var random = new Random();

            /*Rozdělení do solo funkce .. WIP .. předělat Json strukturu*/

            var Selected = Cviceni_vyber.CheckBoxSelected;
            var WordList = slovnikKanji.Where(i => Selected.Contains(i.KanjiUroven)).OrderBy(x => random.Next()).Select(x => x.Id).Take(4).ToList();

            var SeznamZnaku = slovnikKanji.Where(i => i.KanjiUroven == "N5" || i.KanjiUroven == "N4").OrderBy(x => random.Next()).Select(x => x.Id).Take(4).ToList();
            var RandomKanji = SeznamZnaku[random.Next(SeznamZnaku.Count)];
            var KanjiZnak = slovnikKanji.FirstOrDefault(i => i.Id == RandomKanji);
            Kanji = KanjiZnak.KanjiZnak;
            Furigana = KanjiZnak.KanjiJp;
            Cesky = KanjiZnak.KanjiCZ;




            /*Random vyber sklonovani slovesa ..dodelat selekci a trideni*/

            var VerbList = slovnikKanji
             .Where(i => Selected.Contains(i.KanjiUroven))
             .OrderBy(x => random.Next())
             .Select(x => x.Id)
             .Take(1)
             .ToList();

            int KID = VerbList.FirstOrDefault();
            string[] VerbExerciseTypes = new string[] { "PresentPolite", "PresentPlain", "VolitionalPolite", "VolitionalPlain", "ImperativePolite", "ImperativePlain", "PastIndicativePolite",
                "PastIndivacativePlain", "PastPresumptivePolite", "PastPresumptivePlain", "PresentProgressivePlain", "PastProgressivePolite", "PastProgressivePlain", "ProvisionalConditionalPolite",
                "ProvisionalConditionalPlain", "ConditionalPolite", "ConditionalPlain", "PotentialPolite", "PotentialPlain", "CausativePolite", "CausativePlain" };

            KanjiZnak.Conjugations.PresentPolite = nameof(ConjugationModel.PresentPolite);
            KanjiZnak.Conjugations.PresentPlain = nameof(ConjugationModel.PresentPlain);
            KanjiZnak.Conjugations.VolitionalPolite = nameof(ConjugationModel.VolitionalPolite);
            KanjiZnak.Conjugations.VolitionalPlain = nameof(ConjugationModel.VolitionalPlain);
            KanjiZnak.Conjugations.ImperativePolite = nameof(ConjugationModel.ImperativePolite);
            KanjiZnak.Conjugations.ImperativePlain = nameof(ConjugationModel.ImperativePlain);

            KanjiZnak.ConjugationsCollection = new SortedDictionary<string, string>()
            {
                { nameof(ConjugationModel.PresentPolite), KanjiZnak.Conjugations.PresentPolite },
                { nameof(ConjugationModel.PresentPlain), KanjiZnak.Conjugations.PresentPlain },
                { nameof(ConjugationModel.VolitionalPolite), KanjiZnak.Conjugations.VolitionalPolite },
                { nameof(ConjugationModel.VolitionalPlain), KanjiZnak.Conjugations.VolitionalPlain },
                { nameof(ConjugationModel.ImperativePolite), KanjiZnak.Conjugations.ImperativePolite },
                { nameof(ConjugationModel.ImperativePlain), KanjiZnak.Conjugations.ImperativePlain }
            };

            var randomConjugations = KanjiZnak.ConjugationsCollection
                .OrderBy(x => random.Next())
                .Take(4);

            List<string> VerbExerciseTypesList = new List<string>(VerbExerciseTypes);
            var RandomVerbTypes = VerbExerciseTypesList.OrderBy(x => random.Next()).Take(4).ToList();
            var RandomVerbExerciseType = VerbExerciseTypes[random.Next(VerbExerciseTypesList.Count)];
            var RandomVerb = slovnikKanji.Where(i => i.Id == KID).OrderBy(x => random.Next()).Select(x => x).ToList();
            var Verb = slovnikKanji.FirstOrDefault(i => i.Id == KID);
            //var test2 = slovnikKanji.Where(test2 => test2.Id == KID).Select(x => x.PresentPolite).ToList();

            foreach (var conjugation in randomConjugations)
            {
                var test = slovnikKanji
                    .Where(test2 => test2.Id == KID)
                    .Select(x => x.GetType().GetProperty(conjugation.Key).GetValue(x, null))
                    .ToList();
            }









            /*Pridat exercise list , do kterého psát typy ( abecedy,kanji,slovesa) - selekce dle typu přidat if podmínky do selekce*/
            var Preklad = slovnikKanji.Where(i => SeznamZnaku.Contains(i.Id)).Select(x => x.KanjiCZ).ToList();
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
            if (VyberCviceni.btn == "Abecedy")
            {
                if (VyberCviceni.Hiragana == true && VyberCviceni.Katakana == true)
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

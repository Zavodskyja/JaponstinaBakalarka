﻿using System;
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

        string CorrectAnswer { get; set; }


        string CurrentSet { get; set; }



        private Timer timer10Seconds;

        private Timer timer2Seconds;









        public VyukaKanji()
        {
            InitializeComponent();


            timer10Seconds = new Timer
            {
                Interval = 10000 // 10 sekund
            };
            timer10Seconds.Tick += Timer10Seconds_Tick;

            timer2Seconds = new Timer
            {
                Interval = 2000 // 2 sekundy
            };
            timer2Seconds.Tick += Timer2Seconds_Tick;

            KanjiMain();

        }



        private void Kanji_Load(object sender, EventArgs e)
        {


        }

        public void KanjiMain()

        {

            PickSet();



        }


        private void KanjiInHiragana(string kanji, string furigana, string correctConjugationType)
        {
            kanji_char.Text = string.IsNullOrEmpty(kanji) ? furigana : kanji;
            kanji_hiragana.Text = string.IsNullOrEmpty(kanji) ? "" : furigana;
            if (CurrentSet is "RU - Ichidan" or "U - Godan" or "Nepravidelná")
            {
                label2.Text = correctConjugationType;
            }
        }


        public void PickSet()
        {
            var random = new Random();
            int randomIndex = random.Next(Cviceni_vyber.CheckBoxSelected.Count);
            CurrentSet = Cviceni_vyber.CheckBoxSelected[randomIndex];


            if (CurrentSet is "Hiragana" or "Katakana")
            {

                AlphabetRandomFunction();
            }

            if (CurrentSet is "N5" or "N4")
            {
                KanjiRandomFunction();
            }

            if (CurrentSet is "RU - Ichidan" or "U - Godan" or "Nepravidelná")
            {
                ConjugationRandomFunction();
            }

        }

        public void KanjiRandomFunction()
        {
            ClearText();
            var slovnik = ProgressManager.KanjiLoadData.Data;
            var random = new Random();
            var SeznamZnaku = slovnik.Where(i => i.KanjiUroven == CurrentSet).OrderBy(x => random.Next()).Select(x => x.Id).Take(4).ToList();
            var RandomKanji = SeznamZnaku[random.Next(SeznamZnaku.Count)];
            var KanjiZnak = slovnik.FirstOrDefault(i => i.Id == RandomKanji);
            Kanji = KanjiZnak.KanjiZnak;
            Furigana = KanjiZnak.KanjiJp;
            CorrectAnswer = KanjiZnak.KanjiCZ;
            var Preklad = slovnik.Where(i => SeznamZnaku.Contains(i.Id)).Select(x => x.KanjiCZ).ToList();
            var PrekladRandom = Preklad.OrderBy(a => random.Next()).ToList();
            ButtonText(PrekladRandom);
            ButtonDefault();
            KanjiInHiragana(Kanji, Furigana,null);
            

            if (Cviceni_vyber.CheckBoxTimeLimit)
            {
                timer10Seconds.Start();
            }

        }


        public void ConjugationRandomFunction()
        {
            ClearText();
            var slovnik = ProgressManager.KanjiLoadData.Data;
            var random = new Random();
            var verbs = slovnik.Where(i => i.Typ2 == CurrentSet).OrderBy(x => random.Next()).Take(4).ToList();
            var randomVerb = verbs[random.Next(verbs.Count)];
            Kanji = randomVerb.KanjiZnak;
            Furigana = randomVerb.KanjiJp;
            var conjugations = randomVerb.Conjugation.ToList();
            var shuffledConjugationPairs = conjugations.OrderBy(a => random.Next()).ToList();
            var shuffledConjugations = shuffledConjugationPairs.OrderBy(a => random.Next()).Select(pair => pair.Value).ToList();
            ButtonText(shuffledConjugations);
            string correctConjugationType = shuffledConjugationPairs[0].Key;
            string correctConjugationForm = shuffledConjugationPairs[0].Value;
            CorrectAnswer = correctConjugationForm;
            ButtonDefault();
            KanjiInHiragana(Kanji, Furigana, correctConjugationType);
            
        }


        public void AlphabetRandomFunction()
        {

            ClearText();
            if (!Enum.TryParse(typeof(abeceda), CurrentSet, out object abecedaValue))
            {
                throw new ArgumentException("Invalid value for CurrentSet.");
            }
            abeceda currentAbeceda = (abeceda)abecedaValue;

            var slovnik = JP.Slovnik();
            var random = new Random();
            var SeznamZnaku = slovnik.Where(i => i.Key.znaky == currentAbeceda).OrderBy(x => random.Next()).Select(x => x.Key.ID).Take(4).ToList();
            var RandomJpZnaku = SeznamZnaku[random.Next(SeznamZnaku.Count)];
            var Znak = slovnik.FirstOrDefault(i => i.Key.ID == RandomJpZnaku);
            CorrectAnswer = Znak.Value.CZ;
            kanji_char.Text = Znak.Value.JP;
            var Preklad = slovnik.Where(i => SeznamZnaku.Contains(i.Key.ID)).Select(x => x.Value.CZ).ToList();
            var PrekladRandom = Preklad.OrderBy(a => random.Next()).ToList();
            ButtonText(PrekladRandom);
            ButtonDefault();

            if (Cviceni_vyber.CheckBoxTimeLimit)
            {
                timer10Seconds.Start();
            }
        }




        //Pridat logiku na kontrolu odpovedi a né porovnání button.text
        private void kanji_button1_Click(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            ButtonAnswer(clickedButton, clickedButton.Text);
        }

        private void kanji_button2_Click(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            ButtonAnswer(clickedButton, clickedButton.Text);
        }

        private void kanji_button3_Click(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;
            ButtonAnswer(clickedButton, clickedButton.Text);
        }

        private void kanji_button4_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            ButtonAnswer(clickedButton, clickedButton.Text);

        }




        public void ClearText()
        {
            Label[] labels = { label1, label2, kanji_char, kanji_hiragana };
            for (int i = 0; i < labels.Count(); i++)
                labels[i].Text = "";
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

        public void ButtonText(List<string> buttonText)
        {

            Button[] buttons = { Vyuka_button1, Vyuka_button2, Vyuka_button3, Vyuka_button4 };
            for (int i = 0; i < buttons.Count(); i++)
                buttons[i].Text = buttonText[i];
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


        public async void ButtonAnswer(Button button, string buttonText)
        {
            ButtonDisable();
            //pridat logiku na save progressu pro correct X incorrect
            if (buttonText == CorrectAnswer)
            {
                button.BackColor = Color.Green;
                await Task.Delay(1000);
                KanjiMain();
            }
            else
            {
                button.BackColor = Color.FromArgb(188, 0, 45);
                DisplayCorrectAnswer();
                await Task.Delay(2000);
                KanjiMain();

            }
        }






        private void Timer10Seconds_Tick(object sender, EventArgs e)
        {
            timer10Seconds.Stop();
            ButtonDisable();
            DisplayCorrectAnswer();
            timer2Seconds.Start();
        }

        private void Timer2Seconds_Tick(object sender, EventArgs e)
        {
            timer2Seconds.Stop();
            KanjiMain();
        }

        private void DisplayCorrectAnswer()
        {
            label1.Text = CorrectAnswer; //120, 119, 155 barva 
            Button[] buttons = { Vyuka_button1, Vyuka_button2, Vyuka_button3, Vyuka_button4 };
            for (int i = 0; i < buttons.Count(); i++)
                if (buttons[i].Text == CorrectAnswer)
                {
                    buttons[i].BackColor = Color.FromArgb(120, 119, 155);
                }


        }

    }
}

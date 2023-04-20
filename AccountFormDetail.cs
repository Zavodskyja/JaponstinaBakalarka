using Japonstina.models;
using Japonstina.Models;
using Japonstina.vyuka;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Japonstina
{
    public class AccountFormDetail
    {

        public void SetAccountForm(string form)
        {
            if (StavAplikace.ActiveForm != form)
            {
                StavAplikace.ActiveForm = form;
                Program.welcome.panel1.Controls.Clear();

                if (form == "DetailKatakana" || form == "DetailKanji" || form == "DetailSlovesa" || form == "AccountDetail")
                {
                    AccountDetail2 a = new AccountDetail2();
                    a.TopLevel = false;
                    Program.welcome.panel1.Controls.Add(a);
                    a.Dock = DockStyle.Fill;
                    a.Show();
                    UpdateLabels(a, form);
                }

                else
                {
                    account a = new account();
                    a.SetCheckedState(form);
                    a.TopLevel = false;
                    Program.welcome.panel1.Controls.Add(a);
                    a.Dock = DockStyle.Fill;
                    a.Show();
                    //UpdateLabels(a, form);
                }
            }
        }

        public void UpdateLabels(AccountDetail2 accountDetailInstance, string form)
        {
            if (form == "DetailKatakana")
            {
                accountDetailInstance.labelTop.Text = "Hiragana";
                accountDetailInstance.labelMid.Text = "Katakana";
                accountDetailInstance.panel3.Visible = false;
                accountDetailInstance.progressBar1.Name = "Hiragana";
                accountDetailInstance.progressBar2.Name = "Katakana";
                ProgressDataGeneral(accountDetailInstance, form);
            }

            if (form == "DetailKanji")
            {
                accountDetailInstance.labelTop.Text = "N5";
                accountDetailInstance.labelMid.Text = "N4";
                accountDetailInstance.panel3.Visible = false;
                accountDetailInstance.progressBar1.Name = "N5";
                accountDetailInstance.progressBar2.Name = "N4";
                ProgressDataGeneral(accountDetailInstance, form);
            }
            if (form == "DetailSlovesa")
            {
                accountDetailInstance.labelTop.Text = "RU - Ichidan";
                accountDetailInstance.labelMid.Text = "U - Godan";
                accountDetailInstance.labelBot.Text = "Nepravidelná";
                accountDetailInstance.progressBar1.Name = "RU - Ichidan";
                accountDetailInstance.progressBar2.Name = "U - Godan";
                accountDetailInstance.progressBar3.Name = "Nepravidelné";
                ProgressDataGeneral(accountDetailInstance, form);
            }

            if (form == "AccountDetail")
            {
                accountDetailInstance.labelTop.Text = "Abecedy";
                accountDetailInstance.labelMid.Text = "Kanji";
                accountDetailInstance.labelBot.Text = "Slovesa";
                accountDetailInstance.progressBar1.Name = "DetailKatakana";
                accountDetailInstance.progressBar2.Name = "DetailKanji";
                accountDetailInstance.progressBar3.Name = "DetailSlovesa";
                ProgressDataGeneral(accountDetailInstance, form);
            }
        }

        public void UpdateGraph(AccountDetail2 accountDetailInstance, string form)
        {

        }

        public void GetGraphInfo(string form)
        {

        }



        public void ProgressDataGeneral(AccountDetail2 accountDetailInstance, string form)
        {
            ProgressDataModel progressDataKatakana = ProgressManager.ProgressData;
            var katakanaDictionary = JP.Slovnik();
            var kanjiDictionary = ProgressManager.KanjiLoadData.Data;
            if (form == "AccountDetail")
            {
                List<int> completedIdKatakana = new List<int>();
                List<int> completedIdKanji = new List<int>();
                List<int> completedIdVerbs = new List<int>();
                List<string> sourceListKatakana = new List<string>();
                List<string> sourceListKanji = new List<string>();
                List<string> sourceListVerbs = new List<string>();


                sourceListKatakana = katakanaDictionary.Where(i => i.Key.znaky == abeceda.Katakana || i.Key.znaky == abeceda.Hiragana).Select(x => x.Value.JP).ToList();
                completedIdKatakana = progressDataKatakana.JapaneseProgress.Katakana
                    .Where(a => a.KatakanaCompletion == true && (a.Alphabet == "Hiragana" || a.Alphabet == "Katakana"))
                    .Select(i => i.KatakanaId)
                    .ToList();
                var katakanaValue = (int)((double)completedIdKatakana.Count() / sourceListKatakana.Count * 100);
                accountDetailInstance.labelTopCompleteNumber.Text = completedIdKatakana.Count().ToString();
                accountDetailInstance.labelTopMissingNumber.Text = (sourceListKatakana.Count() - completedIdKatakana.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar1, katakanaValue);

                sourceListKanji = kanjiDictionary.Where(i => i.KanjiUroven == "N5" || i.KanjiUroven == "N4").Select(x => x.KanjiJp).ToList();
                completedIdKanji = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.KanjiCompletion == true && ((a.Level == "N5" || a.Level == "N4")))
                    .Select(i => i.Id)
                    .ToList();
                var kanjiValue = (int)((double)completedIdKanji.Count() / sourceListKanji.Count * 100);
                accountDetailInstance.labelMidCompleteNumber.Text = completedIdKanji.Count().ToString();
                accountDetailInstance.labelMidMissingNumber.Text = (sourceListKanji.Count() - completedIdKanji.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar2, kanjiValue);


                sourceListVerbs = kanjiDictionary.Where(i => i.Typ2 == "RU - Ichidan" || i.Typ2 == "U - Godan" || i.Typ2 == "Nepravidelné").Select(x => x.KanjiJp).ToList();
                completedIdVerbs = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.ConjugationCompletion == true && (a.Type == "RU - Ichidan" || a.Type == "U - Godan" || a.Type == "Nepravidelné"))
                .Select(i => i.Id)
                    .ToList();
                var verbValue = (int)((double)completedIdVerbs.Count() / sourceListVerbs.Count * 100);
                accountDetailInstance.labelBotCompleteNumber.Text = completedIdVerbs.Count().ToString();
                accountDetailInstance.labelBotMissingNumber.Text = (sourceListVerbs.Count() - completedIdVerbs.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar3, verbValue);
            }

            if (form == "DetailKatakana")
            {
               var sourceListHiragana = katakanaDictionary.Where(i => i.Key.znaky == abeceda.Hiragana).Select(x => x.Value.JP).ToList();
               var sourceListKatakana = katakanaDictionary.Where(i => i.Key.znaky == abeceda.Katakana).Select(x => x.Value.JP).ToList();

               var completedIdHiragana = progressDataKatakana.JapaneseProgress.Katakana
                    .Where(a => a.KatakanaCompletion == true && a.Alphabet == "Hiragana")
                    .Select(i => i.KatakanaId)
                    .ToList();
                var hiraganaValue = (int)((double)completedIdHiragana.Count() / sourceListHiragana.Count * 100);
                accountDetailInstance.labelTopCompleteNumber.Text = completedIdHiragana.Count().ToString();
                accountDetailInstance.labelTopMissingNumber.Text = (sourceListHiragana.Count() - completedIdHiragana.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar1, hiraganaValue);


                var completedIdKatakana = progressDataKatakana.JapaneseProgress.Katakana
                    .Where(a => a.KatakanaCompletion == true && a.Alphabet == "Katakana")
                    .Select(i => i.KatakanaId)
                    .ToList();
                var katakanaValue = (int)((double)completedIdKatakana.Count() / sourceListKatakana.Count * 100);
                accountDetailInstance.labelMidCompleteNumber.Text = completedIdKatakana.Count().ToString();
                accountDetailInstance.labelMidMissingNumber.Text = (sourceListKatakana.Count() - completedIdKatakana.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar2, katakanaValue);
            }
            if (form == "DetailKanji")
            {

                var sourceListN5 = kanjiDictionary.Where(i => i.KanjiUroven =="N5").Select(x => x.KanjiJp).ToList();
                var sourceListN4 = kanjiDictionary.Where(i => i.KanjiUroven == "N4").Select(x => x.KanjiJp).ToList();

                var completedN5 = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.KanjiCompletion == true && a.Level == "N5")
                    .Select(i => i.Id)
                    .ToList();
                var n5Value = (int)((double)completedN5.Count() / sourceListN5.Count * 100);
                accountDetailInstance.labelTopCompleteNumber.Text = completedN5.Count().ToString();
                accountDetailInstance.labelTopMissingNumber.Text = (sourceListN5.Count() - completedN5.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar1, n5Value);


                var completedN4 = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.KanjiCompletion == true && a.Level == "N4")
                    .Select(i => i.Id)
                    .ToList();
                var n4Value = (int)((double)completedN4.Count() / sourceListN4.Count * 100);
                accountDetailInstance.labelMidCompleteNumber.Text = completedN4.Count().ToString();
                accountDetailInstance.labelMidMissingNumber.Text = (sourceListN4.Count() - completedN4.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar2, n4Value);

            }
            if (form == "DetailSlovesa")
            {
                var sourceListRuVerbs = kanjiDictionary.Where(i => i.Typ2 == "RU - Ichidan").Select(x => x.KanjiJp).ToList();
                var sourceListUVerbs = kanjiDictionary.Where(i => i.Typ2 == "U - Godan").Select(x => x.KanjiJp).ToList();
                var sourceListIrregular = kanjiDictionary.Where(i => i.Typ2 == "Nepravidelné").Select(x => x.KanjiJp).ToList();


                var completedIdRUVerbs = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.ConjugationCompletion == true && a.Type == "RU - Ichidan")
                    .Select(i => i.Id)
                    .ToList();

                var ruVerbValue = (int)((double)completedIdRUVerbs.Count() / sourceListRuVerbs.Count * 100);
                accountDetailInstance.labelTopCompleteNumber.Text = completedIdRUVerbs.Count().ToString();
                accountDetailInstance.labelTopMissingNumber.Text = (sourceListRuVerbs.Count() - completedIdRUVerbs.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar1, ruVerbValue);



                var completedIdUVerbs = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.ConjugationCompletion == true && a.Type == "U - Godan")
                    .Select(i => i.Id)
                    .ToList();

                var uVerbValue = (int)((double)completedIdUVerbs.Count() / sourceListUVerbs.Count * 100);
                accountDetailInstance.labelMidCompleteNumber.Text = completedIdUVerbs.Count().ToString();
                accountDetailInstance.labelMidMissingNumber.Text = (sourceListUVerbs.Count() - completedIdUVerbs.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar2, uVerbValue);



                var completedIdIrregular = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.ConjugationCompletion == true && a.Type == "Nepravidelné")
                    .Select(i => i.Id)
                    .ToList();


                var verbValue = (int)((double)completedIdIrregular.Count() / sourceListIrregular.Count * 100);
                accountDetailInstance.labelBotCompleteNumber.Text = completedIdIrregular.Count().ToString();
                accountDetailInstance.labelBotMissingNumber.Text = (sourceListIrregular.Count() - completedIdIrregular.Count()).ToString();
                SetGraph(accountDetailInstance.progressBar3, verbValue);

            }


        }

        public void SetGraph(TransparentProgressBar item, int value)
        {
            item.Value = value;
            if (item.Value < 30)
            {
                item.ForeColor = Color.FromArgb(195, 39, 43);
            }
            else if (item.Value >= 30 || item.Value < 100)
            {
                item.ForeColor = Color.FromArgb(240, 143, 144);
            }

            else if (item.Value == 100)
            {
                item.ForeColor = Color.FromArgb(165, 186, 147);
            }
        }


    }
}

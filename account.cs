﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japonstina;
using Japonstina.Models;



namespace Japonstina
{
    public partial class account : Form
    {

        public static int HiraganaProgress { get; set; }
        public static int KatakanaProgress { get; set; }


        AccountDataSetup Instance = new AccountDataSetup();

        public account()
        {
            InitializeComponent();
            //SetCheckedState("Hiragana");
        }




        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bar_Click(object sender, EventArgs e)
        {

        }

        private void account_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KatakanaList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KatakanaGraf_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


        public List<int> ProgressData(string requestedData)
        {
            ProgressDataModel progressDataKatakana = ProgressManager.ProgressData;
            List<int> completedIds = new List<int>();

            if (requestedData is "Hiragana" or "Katakana")
            {
                completedIds = progressDataKatakana.JapaneseProgress.Katakana
                    .Where(a => a.KatakanaCompletion == true && a.Alphabet == requestedData)
                    .Select(i => i.KatakanaId)
                    .ToList();
            }
            if (requestedData is "N4" or "N5")
            {
                completedIds = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.KanjiCompletion == true && a.Level == requestedData)
                    .Select(i => i.Id)
                    .ToList();
            }

            if (requestedData is "RU - Verbs" or "U - Verbs" or "Nepravidelné")
            {
                completedIds = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.ConjugationCompletion == true && a.Type == requestedData)
                    .Select(i => i.Id)
                    .ToList();
            }
            return completedIds;
        }

        public void SetCheckedState(string detailType)
        {
            labelDetail.Text = detailType;

            var katakanaDictionary = vyuka.JP.Slovnik();
            var kanjiDictionary = ProgressManager.KanjiLoadData.Data;
            ProgressDataModel progressDataKatakana = ProgressManager.ProgressData;
            List<string> sourceList = new List<string>();
            List<int> completedList = new List<int>();
            var completedCount = sourceList.Count();
            completedList = ProgressData(detailType);
            var completedListCount = completedList.Count();
            var sourcelistCount = sourceList.Count();


            /*TODO - dodelat do ProgressManager.ProgressAccount(HiraganaCount, SplnenoH, KatakanaCount, SplnenoK);
            
            completedListCount = completedList.Count();
            */



            if (detailType == "Katakana")
            {
                sourceList = katakanaDictionary.Where(i => i.Key.znaky == vyuka.abeceda.Katakana).Select(x => x.Value.JP).ToList();
                AccountListFill(sourceList, completedList, detailType);

            }

            if (detailType == "Hiragana")
            {
                sourceList = katakanaDictionary.Where(i => i.Key.znaky == vyuka.abeceda.Hiragana).Select(x => x.Value.JP).ToList();
                AccountListFill(sourceList, completedList, detailType);
            }

            if (detailType == "N5")
            {
                sourceList = kanjiDictionary.Where(i => i.KanjiUroven == detailType).Select(x => x.KanjiJp).ToList();
                AccountListFill(sourceList, completedList, detailType);
            }

            if (detailType == "N4")
            {
                sourceList = kanjiDictionary.Where(i => i.KanjiUroven == detailType).Select(x => x.KanjiJp).ToList();
                AccountListFill(sourceList, completedList, detailType);
            }

            if (detailType == "RU - Ichidan")
            {
                sourceList = kanjiDictionary.Where(i => i.Typ2 == detailType).Select(x => x.KanjiJp).ToList();
                AccountListFill(sourceList, completedList, detailType);
            }

            if (detailType == "U - Godan")
            {
                sourceList = kanjiDictionary.Where(i => i.Typ2 == detailType).Select(x => x.KanjiJp).ToList();
                AccountListFill(sourceList, completedList, detailType);
            }
            if (detailType == "Nepravidelné")
            {
                sourceList = kanjiDictionary.Where(i => i.Typ2 == detailType).Select(x => x.KanjiJp).ToList();
                AccountListFill(sourceList, completedList, detailType);
            }




        }
        public string GetZnakID(int id, string detailType)
        {
            if (detailType is "Hiragana" or "Katakana")
            {
                var slovnik = vyuka.JP.Slovnik();
                var Znak = slovnik.FirstOrDefault(i => i.Key.ID == id);
                var JpZnak = Znak.Value.JP;
                return JpZnak;
            }
            else
            {
                var slovnik = ProgressManager.KanjiLoadData.Data;
                var Znak = slovnik.FirstOrDefault(i => i.Id == id);
                var JpZnak = Znak.KanjiJp;
                return JpZnak;
            }

        }


        public void AccountListFill(List<string> sourceList, List<int> completedList, string detailType)
        {
            double graphValue = (double)completedList.Count() / sourceList.Count() * 100;
            progressBarCircle.Value = (int)graphValue;
            labelSplnenoValue.Text = completedList.Count().ToString();
            labelNesplnenoValue.Text = (sourceList.Count() - completedList.Count()).ToString();
            foreach (string character in sourceList)
            {
                ItemList.Items.Add(character);
            }

            CheckListWidth(sourceList);
            checkBox(completedList, detailType);


        }

        public void CheckListWidth(List<string> sourceList)
        {
            int maxWidth = 0;
            using (Graphics g = ItemList.CreateGraphics())
            {
                foreach (object item in ItemList.Items)
                {
                    int itemWidth = (int)g.MeasureString(item.ToString(), ItemList.Font).Width;
                    maxWidth = Math.Max(maxWidth, itemWidth);
                }
            }
            if(maxWidth > 100)
            {
                ItemList.ColumnWidth = maxWidth + SystemInformation.VerticalScrollBarWidth + 10;
            }
            else
            {
                ItemList.ColumnWidth = 100;
            }
        }

        private void KatakanaProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void checkBox(List<int> completedList, string detailType)
        {
            foreach (int ID in completedList)
            {
                string character = GetZnakID(ID, detailType);
                int index = ItemList.FindStringExact(character);
                if (index != -1)
                {
                    ItemList.SetItemChecked(index, true);
                }
            }

        }
    }
}

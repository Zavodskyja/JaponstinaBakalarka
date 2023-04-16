using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japonstina.Models;
using Japonstina.vyuka;
using Newtonsoft.Json;

namespace Japonstina
{
    public partial class account : Form
    {

        public static int HiraganaProgress { get; set; }
        public static int KatakanaProgress { get; set; }



        public account()
        {

            InitializeComponent();
            //TODO:Dodělat logiku na plnění checkboxu

            

            //TODO: Předělat na classu mimo formu
            
            var slovnik = JP.Slovnik();
            var ProgressHiragana = slovnik.Where(i => i.Key.znaky == abeceda.Hiragana).Select(x => x.Value.JP).ToList();
            var HiraganaCount = ProgressHiragana.Count();
            var ProgressKatakana = slovnik.Where(i => i.Key.znaky == abeceda.Katakana).Select(x => x.Value.JP).ToList();
            var KatakanaCount = ProgressKatakana.Count();
            ProgressManager.ProgressAccountZnaky();
            var ZnakSplnenoH = ProgressManager.ProgressData.ProgressZnaku.Where(a => a.ZnakSplneno == true && a.Abeceda == "Hiragana").Select(i => i.ZnakId).ToList();
            var ZnakSplnenoK = ProgressManager.ProgressData.ProgressZnaku.Where(a => a.ZnakSplneno == true && a.Abeceda == "Katakana").Select(i => i.ZnakId).ToList();
            var SplnenoH = ZnakSplnenoH.Count();
            var SplnenoK = ZnakSplnenoK.Count();
           
            

            ProgressManager.ProgressAccount(HiraganaCount, SplnenoH, KatakanaCount, SplnenoK);

            HiraganaGraf.Value = HiraganaProgress;
            KatakanaGraf.Value = KatakanaProgress;
            HiraganaGraf.Text = HiraganaProgress + "%".ToString();
            KatakanaGraf.Text = KatakanaProgress + "%".ToString();


            foreach (string znak in ProgressHiragana)
            {
                HiraganaList.Items.Add(znak);

            }
            foreach (string znak in ProgressKatakana)
            {
                KatakanaList.Items.Add(znak);
            }

            foreach (int ID in ZnakSplnenoH)
            {

                HiraganaList.SetItemChecked(ID, true);

            }
            foreach (int ID in ZnakSplnenoK)
            {

                KatakanaList.SetItemChecked(ID, true);

            }

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
    }
}

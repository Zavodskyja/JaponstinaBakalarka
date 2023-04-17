using CircularProgressBar;
using Japonstina.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japonstina
{
    //TODO , dodelat predani barů
    public class AccountDataSetup
    {
        public List<int> ProgressData(string requestedData)
        {

            ProgressDataModel progressData = ProgressManager.ProgressData;
            KanjiDataModel kanjiLoadData = ProgressManager.KanjiLoadData;


            var completedKatakana = progressData.JapaneseProgress.Katakana
                .Where(a => a.KatakanaCompletion == true && a.Alphabet == requestedData)
                .Select(i => i.KatakanaId)
                .ToList();

            return completedKatakana;
        }

        public void SetProgressBar(int progressBar1, int progressBar2, params CircularProgressBar2[] progressBars)
        {

            foreach (CircularProgressBar2 setType in progressBars)
            {
                if (setType.Name == "HiraganaProgressBar")
                {
                    setType.Value = progressBar1;
                }
                else if (setType.Name == "KatakanaProgressBar")
                {
                    setType.Value = progressBar2;
                }
                else if (setType.Name == "N5ProgressBar")
                {

                }
                else if (setType.Name == "N4ProgressBar")
                {

                }
                else if (setType.Name == "RuVerbsProgressBar")
                {

                }
                else if (setType.Name == "uVerbsProgressBar")
                {

                }
                else if (setType.Name == "IrregularVerbsProgressBar")
                {

                }

            }

        }
    }
}
    


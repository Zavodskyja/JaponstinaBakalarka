using CircularProgressBar;
using Japonstina.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japonstina.models;

namespace Japonstina
{
    //TODO , dodelat predani barů
    public class AccountDataSetup
    {

        List<int> completedKatakana = new List<int>();
        List<int> completedKanji = new List<int>();
        List<int> completedVerbs = new List<int>();


        public void SetCircleProgressBar(CircularProgressBar2 progressBar)
        {
            progressBar.Value = 50;
        }


        public void LoadProgressData()
        {
            ProgressDataModel progressDataKatakana = ProgressManager.ProgressData;

            completedKatakana = progressDataKatakana.JapaneseProgress.Katakana
                    .Where(a => a.KatakanaCompletion == true && (a.Alphabet == "Hiragana" || a.Alphabet == "Katakana"))
                    .Select(i => i.KatakanaId)
                    .ToList();


            completedKanji = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.KanjiCompletion == true && (a.Level == "N5" || a.Level == "N4"))
                    .Select(i => i.Id)
                    .ToList();


            completedVerbs = progressDataKatakana.JapaneseProgress.Vocabulary
                    .Where(a => a.ConjugationCompletion == true && (a.Type == "RU - Ichidan" || a.Type == "U - Godan" || a.Type == "Nepravidelné"))
                    .Select(i => i.Id)
                    .ToList();
        }

        public void SetProgressData()
        {
            if(StavAplikace.ActiveForm == "DetailKatakana")
            {

            }

            if (StavAplikace.ActiveForm == "DetailKanji")
            {

            }

            if (StavAplikace.ActiveForm == "DetailSlovesa")
            {

            }

        }
    }
}

    


using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Japonstina.vyuka;
using Japonstina.Models;
using Japonstina.models;
using System.IO;
using Japonstina.Properties;
using System.Text;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Japonstina
{
    public static class ProgressManager
    {
        public static ProgressDataModel ProgressData { get; set; }

        public static KanjiDataModel KanjiLoadData { get; set; }

        public static ZnakModel HiraganaLoadData { get; set; }

        public static Japanese KatakanaProgress { get; set; }

        public static ProgressDataModel VocabularyProgress { get; set; }




        public static void Init()
        {
            LoadKanji();
            var slovnik = JP.Slovnik();
            var slovnikKanji = KanjiLoadData.Data;
            var KanjiSlovnik = Kanji.Slovnik();
            var japanese = new Japanese

            {
                Katakana = slovnik.Select(polozka => new Katakana()
                {
                    KatakanaId = polozka.Key.ID,
                    Alphabet = polozka.Key.znaky.ToString(),
                }).ToList()
                ,
                Vocabulary = slovnikKanji.Select(kanji => new VocabularyModel()
                {
                    Id = kanji.Id,
                    Level = kanji.KanjiUroven,
                    Type = kanji.Typ2.ToString(),
                }).ToList(),
            };

            VocabularyProgress = new ProgressDataModel { JapaneseProgress = japanese };


            KanjiLoadData = new KanjiDataModel()
            {
                Data = KanjiSlovnik.Select(kanji => new KanjiModel() 
                {
                    Id = kanji.Key.ID,
                    KanjiUroven = kanji.Key.Uroven.ToString(),
                    Typ1 = kanji.Key.Typ1.ToString(),
                    Typ2 = kanji.Key.Typ2.ToString(),
                    KanjiZnak = kanji.Value.Kanji.ToString(),
                    KanjiJp = kanji.Value.JP.ToString(),
                    KanjiCZ = kanji.Value.CZ.ToString(),
                }).ToList()

            };

        }

        public static void UpdateProgress(string currentSet,int id, bool correctAnswer)
        {
            
            

            if(currentSet == "Hiragana" || currentSet == "Katakana" )
            {
                var znakToUpdate = ProgressData.JapaneseProgress.Katakana.FirstOrDefault(znak => znak.KatakanaId == id);
                if (correctAnswer == true)
                {
                    znakToUpdate.KatakanaProgress++;
                }

                if (znakToUpdate == null)
                {
                    return;
                }
                znakToUpdate.KatakanaCompletion = znakToUpdate.KatakanaProgress == 3 ? true : false;
            }

            if (currentSet == "N5" || currentSet == "N4")
            {
               var znakToUpdate= ProgressData.JapaneseProgress.Vocabulary.FirstOrDefault(znak => znak.Id == id);
                if (correctAnswer == true)
                {
                    znakToUpdate.KanjiProgress = (znakToUpdate.KanjiProgress < 3) ? znakToUpdate.KanjiProgress + 1 : znakToUpdate.KanjiProgress;
                }

                if (znakToUpdate == null)
                {
                    return;
                }
                znakToUpdate.KanjiCompletion = znakToUpdate.KanjiProgress == 3 ? true : false;

            }

            if (currentSet == "RU - Ichidan" || currentSet == "U - Godan" || currentSet == "Nepravidelné")
            {
                var znakToUpdate = ProgressData.JapaneseProgress.Vocabulary.FirstOrDefault(znak => znak.Id == id);
                if (correctAnswer == true)
                {
                    znakToUpdate.ConjugationProgress = (znakToUpdate.ConjugationProgress < 3) ? znakToUpdate.ConjugationProgress + 1 : znakToUpdate.ConjugationProgress;
                }

                if (znakToUpdate == null)
                {
                    return;
                }
                znakToUpdate.ConjugationCompletion = znakToUpdate.ConjugationProgress == 3 ? true : false;

            }
            SaveProgress();
        }

        public static void SaveProgress()
        {
            string json = JsonConvert.SerializeObject(ProgressData, Formatting.Indented);
            var username = Welcome.PrihlasenyUzivatel;
            File.WriteAllText($"Data/{username}", json);
        }

        public static void LoadProgress(string user)
        {
            try
            {
                var username = user;
                var path = $"Data/{username}";
                string jsonFile = File.ReadAllText(path);
                ProgressData = JsonConvert.DeserializeObject<ProgressDataModel>(jsonFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Naskytla se Chyba při načítání dat uživatele {user}. Data byla resetována.", "Chyba uživatele", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstLoginRun(user);
            }
        }

        public static void FirstLoginRun(string user)
        {
            var username = user;
            string json = JsonConvert.SerializeObject(VocabularyProgress, Formatting.Indented);
            var filename = $"Data/{username}";
            if (!File.Exists(filename))
            { File.WriteAllText(filename, json); }
        }

        public static void LoadKanji()
        {
            string jsonFile = Resources.Vocabulary;
            KanjiLoadData = JsonConvert.DeserializeObject<KanjiDataModel>(jsonFile);
        }

    }



}

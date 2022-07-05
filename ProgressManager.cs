﻿using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Japonstina.vyuka;
using Japonstina.Models;
using System.IO;








namespace Japonstina
{
    public static class ProgressManager
    {
        public static ProgressDataModel ProgressData { get; set; }




        public static void Init()
        {

            var slovnik = JP.Slovnik();

            ProgressData = new ProgressDataModel()
            {
                ProgressZnaku = slovnik.Select(polozka => new ZnakModel()
                {
                    ZnakId = polozka.Key.ID,
                    Abeceda = polozka.Key.znaky.ToString()
                    

                }).ToList()
            };

        }

        public static void ProgressAccountZnaky()
        {
            var ZnakSplneno = ProgressData.ProgressZnaku.Where(a => a.ZnakSplneno == true).Select(i => i.ZnakId).ToList<int>();

        }

        public static void UpdateProgress(int znakId, int ChybaPocet)
        {
            var znakToUpdate = ProgressData.ProgressZnaku.FirstOrDefault(znak => znak.ZnakId == znakId);



            if (ChybaPocet == 0)
            {
                znakToUpdate.ZnakProgress++;
            }

            if (znakToUpdate == null)
            {
                return;
            }

            znakToUpdate.ZnakSplneno = znakToUpdate.ZnakProgress == 3 ? true : false;
        }

        public static void SaveProgress()
        {
            string json = JsonConvert.SerializeObject(ProgressData, Formatting.Indented);

            var username = Welcome.PrihlasenyUzivatel;
            File.WriteAllText($"Data/{username}", json);
        }

        public static void LoadProgress(string user)
        {
            var username = user;
            var path = $"Data/{username}";
            string jsonFile = File.ReadAllText(path);
            ProgressData = JsonConvert.DeserializeObject<ProgressDataModel>(jsonFile);

        }

        public static void FirstLoginRun(string user)
        {
            var username = user;
            string json = JsonConvert.SerializeObject(ProgressData, Formatting.Indented);
            var filename = $"Data/{username}";
            if (!File.Exists(filename))
            { File.WriteAllText(filename, json); }
        }

        public static void ProgressAccount(int HiraganaCount, double SplnenoH, int KatakanaCount, double SplnenoK)
        {
            int ZnakyHi = HiraganaCount;
            int ZnakyKa = KatakanaCount; 
            double SplnenoHi = SplnenoH;
            double SplnenoKa = SplnenoK;
            double hiragana = (double)SplnenoHi / ZnakyHi * 100;
            double katakana = (double)SplnenoKa / ZnakyKa * 100;
            ProgressAbecedy(hiragana, katakana);
        }

        public static void ProgressAbecedy(double hiragana, double katakana)
        {
            account.HiraganaProgress = (int)hiragana;
            account.KatakanaProgress = (int)katakana;

        }

        public static void ProgressAbecedy()
        {



        }


    }
}
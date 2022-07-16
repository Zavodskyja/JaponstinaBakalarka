using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Japonstina.vyuka;


namespace Japonstina
{


    public  class KanjiRandom
    {
        

        public int ZnakId { get; set; }

        string Kanji { get; set; }

        string Furigana { get; set; }

        string Cesky { get; set; }





        public void KanjiRandomFunkce()
        {
            var slovnik = ProgressManager.KanjiLoadData.Data;
            var random = new Random();
            var SeznamZnaku = slovnik.Where(i => i.KanjiUroven == "N5" || i.KanjiUroven == "N4").OrderBy(x => random.Next()).Select(x => x.KanjiId).Take(4).ToList(); /*22.6. Predelat dle hiragany pro vetsi seznamy*/
            var RandomKanji = SeznamZnaku[random.Next(SeznamZnaku.Count)]; /*TODO: Dodelat plneni tlacitek*/
            var KanjiZnak = slovnik.FirstOrDefault(i => i.KanjiId == RandomKanji);
            Kanji = KanjiZnak.KanjiZnak;
            Furigana = KanjiZnak.KanjiJp;
            Cesky = KanjiZnak.KanjiCZ;
            var Preklad = slovnik.Where(i => SeznamZnaku.Contains(i.KanjiId)).Select(x => x.KanjiCZ).ToList();
            var PrekladRandom = Preklad.OrderBy(a => random.Next()).ToList();
            /*Tlacitka - Zatim nastrel funkcionality*/
            


        }
        


    }
}

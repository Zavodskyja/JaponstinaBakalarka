using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japonstina.vyuka
{


    public class KanjiZnak
    {
        public string Kanji { get; set; }
        public string JP { get; set; }
        public string CZ { get; set; }

    }

    public class KanjiDetail
    {
        public int ID { get; set; }
        public string Uroven { get; set; }

        public string Typ1 { get; set; }

        public string Typ2 { get; set; }


    }

    public class Kanji
    {
        public static Dictionary<KanjiDetail, KanjiZnak> Slovnik()
        
        {
            return new Dictionary<KanjiDetail, KanjiZnak>()
            {

            };

        }
    }
}


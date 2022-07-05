using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Japonstina.vyuka
{
    public enum JLPT
    {
        N5,
        N4
    }

    public class KanjiZnak
    {
        public string Kanji { get; set; }
        public string JP { get; set; }
        public string CZ { get; set; }

    }

    public class KanjiDetail
    {
        public int ID { get; set; }
        public JLPT Uroven { get; set; }


    }

    public class Kanji
    {
        public static Dictionary<KanjiDetail, KanjiZnak> Slovnik()
        /*TODO? --dodelat rozdeleni na sloveso/pridavne jmeno atd? */
        {
            return new Dictionary<KanjiDetail, KanjiZnak>()
            {
                { new KanjiDetail { ID = 0, Uroven = JLPT.N5 }, new KanjiZnak { Kanji = "浴びる", JP = "あびる", CZ = "Sprchovat se" } },
                { new KanjiDetail { ID = 1, Uroven = JLPT.N5 }, new KanjiZnak { Kanji = "危ない", JP = "あぶない", CZ = "Nebezpečný" } },
                { new KanjiDetail { ID = 2, Uroven = JLPT.N5 }, new KanjiZnak { Kanji = "", JP = "あっち", CZ = "Támhle" } },
                { new KanjiDetail { ID = 3, Uroven = JLPT.N5 }, new KanjiZnak { Kanji = "", JP = "あちら", CZ = "Tam" } },
                { new KanjiDetail { ID = 4, Uroven = JLPT.N5 }, new KanjiZnak { Kanji = "上げる", JP = "あげる", CZ = "Zvednout" } },
                { new KanjiDetail { ID = 5, Uroven = JLPT.N5 }, new KanjiZnak { Kanji = "赤", JP = "あか", CZ = "červená" } },
            };

        }
    }
}

/*

{
  "Znaky": [
    {
      "Id": 0,
      "Uroven": "N5",
      "Detail":[{
        "Typ":"Sloveso",
        "Tvar":"Ru"}],
      "Kanji": "浴びる",
      "JP":"あびる",
      "CZ":"Sprchovat se"
     }
  ]
    }

{
  "Znaky": [
    {
      "Id": 0,
      "Uroven": "N5",
      "Detail":{
        "Typ1":"Sloveso",
        "Typ2":"Ru"},
      "Kanji": "浴びる",
      "JP":"あびる",
      "CZ":"Sprchovat se"
     }
  ]
    }

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Japonstina.vyuka
{
    
       

    public enum abeceda
    {
        Hiragana,
        Katakana
    }
    public class znak
    {
        public string JP { get; set; }
        public string CZ { get; set; }


    }

    public class ZnakDetail
    {
        public int ID { get; set; }
        public abeceda znaky { get; set; }


    }
    public class JP
    {
        public static Dictionary<ZnakDetail, znak> Slovnik()

        {
            return new Dictionary<ZnakDetail, znak>()
     {
          { new ZnakDetail{ID=0,znaky=abeceda.Hiragana}, new znak {JP="あ", CZ="a"} },
          { new ZnakDetail{ID=1,znaky=abeceda.Hiragana}, new znak {JP="い", CZ="i"} },
          { new ZnakDetail{ID=2,znaky=abeceda.Hiragana}, new znak {JP="う", CZ="u"} },
          { new ZnakDetail{ID=3,znaky=abeceda.Hiragana}, new znak {JP="え", CZ="e"} },
          { new ZnakDetail{ID=4,znaky=abeceda.Hiragana}, new znak {JP="お", CZ="o"} },
          { new ZnakDetail{ID=5,znaky=abeceda.Hiragana}, new znak {JP="か", CZ="ka"} },
          { new ZnakDetail{ID=6,znaky=abeceda.Hiragana}, new znak {JP="き", CZ="ki"} },
          { new ZnakDetail{ID=7,znaky=abeceda.Hiragana}, new znak {JP="く", CZ="ku"} },
          { new ZnakDetail{ID=8,znaky=abeceda.Hiragana}, new znak {JP="け", CZ="ke"} },
          { new ZnakDetail{ID=9,znaky=abeceda.Hiragana}, new znak {JP="こ", CZ="ko"} },
          { new ZnakDetail{ID=10,znaky=abeceda.Hiragana}, new znak {JP="さ", CZ="sa"} },
          { new ZnakDetail{ID=11,znaky=abeceda.Hiragana}, new znak {JP="し", CZ="shi"} },
          { new ZnakDetail{ID=12,znaky=abeceda.Hiragana}, new znak {JP="す", CZ="su"} },
          { new ZnakDetail{ID=13,znaky=abeceda.Hiragana}, new znak {JP="せ", CZ="se"} },
          { new ZnakDetail{ID=14,znaky=abeceda.Hiragana}, new znak {JP="そ", CZ="so"} },
          { new ZnakDetail{ID=15,znaky=abeceda.Hiragana}, new znak {JP="た", CZ="ta"} },
          { new ZnakDetail{ID=16,znaky=abeceda.Hiragana}, new znak {JP="ち", CZ="chi"} },
          { new ZnakDetail{ID=17,znaky=abeceda.Hiragana}, new znak {JP="つ", CZ="tsu"} },
          { new ZnakDetail{ID=18,znaky=abeceda.Hiragana}, new znak {JP="て", CZ="te"} },
          { new ZnakDetail{ID=19,znaky=abeceda.Hiragana}, new znak {JP="と", CZ="to"} },
          { new ZnakDetail{ID=20,znaky=abeceda.Hiragana}, new znak {JP="な", CZ="na"} },
          { new ZnakDetail{ID=21,znaky=abeceda.Hiragana}, new znak {JP="に", CZ="ni"} },
          { new ZnakDetail{ID=22,znaky=abeceda.Hiragana}, new znak {JP="ぬ", CZ="nu"} },
          { new ZnakDetail{ID=23,znaky=abeceda.Hiragana}, new znak {JP="ね", CZ="ne"} },
          { new ZnakDetail{ID=24,znaky=abeceda.Hiragana}, new znak {JP="の", CZ="no"} },
          { new ZnakDetail{ID=25,znaky=abeceda.Hiragana}, new znak {JP="は", CZ="ha"} },
          { new ZnakDetail{ID=26,znaky=abeceda.Hiragana}, new znak {JP="ひ", CZ="hi"} },
          { new ZnakDetail{ID=27,znaky=abeceda.Hiragana}, new znak {JP="ふ", CZ="fu"} },
          { new ZnakDetail{ID=28,znaky=abeceda.Hiragana}, new znak {JP="へ", CZ="he"} },
          { new ZnakDetail{ID=29,znaky=abeceda.Hiragana}, new znak {JP="ほ", CZ="ho"} },
          { new ZnakDetail{ID=30,znaky=abeceda.Hiragana}, new znak {JP="ま", CZ="ma"} },
          { new ZnakDetail{ID=31,znaky=abeceda.Hiragana}, new znak {JP="み", CZ="mi"} },
          { new ZnakDetail{ID=32,znaky=abeceda.Hiragana}, new znak {JP="む", CZ="mu"} },
          { new ZnakDetail{ID=33,znaky=abeceda.Hiragana}, new znak {JP="め", CZ="me"} },
          { new ZnakDetail{ID=34,znaky=abeceda.Hiragana}, new znak {JP="も", CZ="mo"} },
          { new ZnakDetail{ID=35,znaky=abeceda.Hiragana}, new znak {JP="ら", CZ="ra"} },
          { new ZnakDetail{ID=36,znaky=abeceda.Hiragana}, new znak {JP="り", CZ="ri"} },
          { new ZnakDetail{ID=37,znaky=abeceda.Hiragana}, new znak {JP="る", CZ="ru"} },
          { new ZnakDetail{ID=38,znaky=abeceda.Hiragana}, new znak {JP="れ", CZ="re"} },
          { new ZnakDetail{ID=39,znaky=abeceda.Hiragana}, new znak {JP="ろ", CZ="ro"} },
          { new ZnakDetail{ID=40,znaky=abeceda.Hiragana}, new znak {JP="や", CZ="ya"} },
          { new ZnakDetail{ID=41,znaky=abeceda.Hiragana}, new znak {JP="ゆ", CZ="yu"} },
          { new ZnakDetail{ID=42,znaky=abeceda.Hiragana}, new znak {JP="よ", CZ="yo"} },
          { new ZnakDetail{ID=43,znaky=abeceda.Hiragana}, new znak {JP="ん", CZ="n" } },
          { new ZnakDetail{ID=44,znaky=abeceda.Hiragana}, new znak {JP="わ", CZ="wa"} },
          { new ZnakDetail{ID=45,znaky=abeceda.Hiragana}, new znak {JP="を", CZ="wo"} },
          { new ZnakDetail{ID=46,znaky=abeceda.Hiragana}, new znak {JP="が", CZ="ga"} },
          { new ZnakDetail{ID=47,znaky=abeceda.Hiragana}, new znak {JP="ぎ", CZ="gi"} },
          { new ZnakDetail{ID=48,znaky=abeceda.Hiragana}, new znak {JP="ぐ", CZ="gu"} },
          { new ZnakDetail{ID=49,znaky=abeceda.Hiragana}, new znak {JP="げ", CZ="ge"} },
          { new ZnakDetail{ID=50,znaky=abeceda.Hiragana}, new znak {JP="ご", CZ="go"} },
          { new ZnakDetail{ID=51,znaky=abeceda.Hiragana}, new znak {JP="ざ", CZ="za"} },
          { new ZnakDetail{ID=52,znaky=abeceda.Hiragana}, new znak {JP="じ", CZ="zi"} },
          { new ZnakDetail{ID=53,znaky=abeceda.Hiragana}, new znak {JP="ず", CZ="zu"} },
          { new ZnakDetail{ID=54,znaky=abeceda.Hiragana}, new znak {JP="ぜ", CZ="ze"} },
          { new ZnakDetail{ID=55,znaky=abeceda.Hiragana}, new znak {JP="ぞ", CZ="zo"} },
          { new ZnakDetail{ID=56,znaky=abeceda.Hiragana}, new znak {JP="ぢ", CZ="ji"} },
          { new ZnakDetail{ID=57,znaky=abeceda.Hiragana}, new znak {JP="づ", CZ="dzu"}},
          { new ZnakDetail{ID=58,znaky=abeceda.Hiragana}, new znak {JP="で", CZ="de"} },
          { new ZnakDetail{ID=59,znaky=abeceda.Hiragana}, new znak {JP="ど", CZ="do"} },
          { new ZnakDetail{ID=60,znaky=abeceda.Hiragana}, new znak {JP="ば", CZ="ba"} },
          { new ZnakDetail{ID=61,znaky=abeceda.Hiragana}, new znak {JP="び", CZ="bi"} },
          { new ZnakDetail{ID=62,znaky=abeceda.Hiragana}, new znak {JP="ぶ", CZ="bu"} },
          { new ZnakDetail{ID=63,znaky=abeceda.Hiragana}, new znak {JP="べ", CZ="be"} },
          { new ZnakDetail{ID=64,znaky=abeceda.Hiragana}, new znak {JP="ぼ", CZ="bo"} },
          { new ZnakDetail{ID=65,znaky=abeceda.Hiragana}, new znak {JP="ぱ", CZ="pa"} },
          { new ZnakDetail{ID=66,znaky=abeceda.Hiragana}, new znak {JP="ぴ", CZ="pi"} },
          { new ZnakDetail{ID=67,znaky=abeceda.Hiragana}, new znak {JP="ぷ", CZ="pu"} },
          { new ZnakDetail{ID=68,znaky=abeceda.Hiragana}, new znak {JP="ぺ", CZ="pe"} },
          { new ZnakDetail{ID=69,znaky=abeceda.Hiragana}, new znak {JP="ぽ", CZ="po"} },
          { new ZnakDetail{ID=70,znaky=abeceda.Katakana }, new znak {JP="ア", CZ="a"} },
          { new ZnakDetail{ID=71,znaky=abeceda.Katakana }, new znak {JP="イ", CZ="i"} },
          { new ZnakDetail{ID=72,znaky=abeceda.Katakana}, new znak {JP="ウ", CZ="u"} },
          { new ZnakDetail{ID=73,znaky=abeceda.Katakana}, new znak {JP="エ", CZ="e"} },
          { new ZnakDetail{ID=74,znaky=abeceda.Katakana }, new znak {JP="オ", CZ="o"} },
          { new ZnakDetail{ID=75,znaky=abeceda.Katakana }, new znak {JP="カ", CZ="ka"} },
          { new ZnakDetail{ID=76,znaky=abeceda.Katakana}, new znak {JP="キ", CZ="ki"} },
          { new ZnakDetail{ID=77,znaky=abeceda.Katakana}, new znak {JP="ク", CZ="ku"} },
          { new ZnakDetail{ID=78,znaky=abeceda.Katakana }, new znak {JP="ケ", CZ="ke"} },
          { new ZnakDetail{ID=79,znaky=abeceda.Katakana }, new znak {JP="コ", CZ="ko"} },
          { new ZnakDetail{ID=80,znaky=abeceda.Katakana}, new znak {JP="サ", CZ="sa"} },
          { new ZnakDetail{ID=81,znaky=abeceda.Katakana}, new znak {JP="シ", CZ="shi"} },
          { new ZnakDetail{ID=82,znaky=abeceda.Katakana }, new znak {JP="ス", CZ="su"} },
          { new ZnakDetail{ID=83,znaky=abeceda.Katakana }, new znak {JP="セ", CZ="se"} },
          { new ZnakDetail{ID=84,znaky=abeceda.Katakana}, new znak {JP="ソ", CZ="so"} },
          { new ZnakDetail{ID=85,znaky=abeceda.Katakana}, new znak {JP="タ", CZ="ta"} },
          { new ZnakDetail{ID=86,znaky=abeceda.Katakana }, new znak {JP="チ", CZ="či"} },
          { new ZnakDetail{ID=87,znaky=abeceda.Katakana }, new znak {JP="ツ", CZ="tsu"} },
          { new ZnakDetail{ID=88,znaky=abeceda.Katakana}, new znak {JP="テ", CZ="te"} },
          { new ZnakDetail{ID=89,znaky=abeceda.Katakana}, new znak {JP="ト", CZ="to"} },
          { new ZnakDetail{ID=90,znaky=abeceda.Katakana }, new znak {JP="ナ", CZ="na"} },
          { new ZnakDetail{ID=91,znaky=abeceda.Katakana }, new znak {JP="ニ", CZ="ni"} },
          { new ZnakDetail{ID=92,znaky=abeceda.Katakana}, new znak {JP="ヌ", CZ="nu"} },
          { new ZnakDetail{ID=93,znaky=abeceda.Katakana}, new znak {JP="ネ", CZ="ne"} },
          { new ZnakDetail{ID=94,znaky=abeceda.Katakana }, new znak {JP="ノ", CZ="no"} },
          { new ZnakDetail{ID=95,znaky=abeceda.Katakana}, new znak {JP="ハ", CZ="ha"} },
          { new ZnakDetail{ID=96,znaky=abeceda.Katakana}, new znak {JP="ヒ", CZ="hi"} },
          { new ZnakDetail{ID=97,znaky=abeceda.Katakana }, new znak {JP="フ", CZ="fu"} },
          { new ZnakDetail{ID=98,znaky=abeceda.Katakana }, new znak {JP="ヘ", CZ="he"} },
          { new ZnakDetail{ID=99,znaky=abeceda.Katakana}, new znak {JP="ホ", CZ="ho"} },
          { new ZnakDetail{ID=100,znaky=abeceda.Katakana}, new znak {JP="マ", CZ="ma"} },
          { new ZnakDetail{ID=101,znaky=abeceda.Katakana }, new znak {JP="ミ", CZ="mi"} },
          { new ZnakDetail{ID=102,znaky=abeceda.Katakana }, new znak {JP="ム", CZ="mu"} },
          { new ZnakDetail{ID=103,znaky=abeceda.Katakana}, new znak {JP="メ", CZ="me"} },
          { new ZnakDetail{ID=104,znaky=abeceda.Katakana}, new znak {JP="モ", CZ="mo"} },
          { new ZnakDetail{ID=105,znaky=abeceda.Katakana }, new znak {JP="ラ", CZ="ra"} },
          { new ZnakDetail{ID=106,znaky=abeceda.Katakana }, new znak {JP="リ", CZ="ri"} },
          { new ZnakDetail{ID=107,znaky=abeceda.Katakana}, new znak {JP="ル", CZ="ru"} },
          { new ZnakDetail{ID=108,znaky=abeceda.Katakana}, new znak {JP="レ", CZ="re"} },
          { new ZnakDetail{ID=109,znaky=abeceda.Katakana }, new znak {JP="ロ", CZ="ro"} },
          { new ZnakDetail{ID=110,znaky=abeceda.Katakana }, new znak {JP="ヤ", CZ="ya"} },
          { new ZnakDetail{ID=111,znaky=abeceda.Katakana}, new znak {JP="ユ", CZ="yu"} },
          { new ZnakDetail{ID=112,znaky=abeceda.Katakana}, new znak {JP="ヨ", CZ="yo"} },
          { new ZnakDetail{ID=113,znaky=abeceda.Katakana }, new znak {JP="ン", CZ="n"} },
          { new ZnakDetail{ID=114,znaky=abeceda.Katakana }, new znak {JP="ワ", CZ="wa"} },
          { new ZnakDetail{ID=115,znaky=abeceda.Katakana}, new znak {JP="ガ", CZ="ga"} },
          { new ZnakDetail{ID=116,znaky=abeceda.Katakana}, new znak {JP="ギ", CZ="gi"} },
          { new ZnakDetail{ID=117,znaky=abeceda.Katakana}, new znak {JP="グ", CZ="gu"} },
          { new ZnakDetail{ID=118,znaky=abeceda.Katakana}, new znak {JP="ゲ", CZ="ge"} },
          { new ZnakDetail{ID=119,znaky=abeceda.Katakana }, new znak {JP="ゴ", CZ="go"} },
          { new ZnakDetail{ID=120,znaky=abeceda.Katakana }, new znak {JP="ザ", CZ="za"} },
          { new ZnakDetail{ID=121,znaky=abeceda.Katakana}, new znak {JP="ジ", CZ="dži"} },
          { new ZnakDetail{ID=122,znaky=abeceda.Katakana}, new znak {JP="ズ", CZ="dzu"} },
          { new ZnakDetail{ID=123,znaky=abeceda.Katakana}, new znak {JP="ゼ", CZ="ze"} },
          { new ZnakDetail{ID=124,znaky=abeceda.Katakana}, new znak {JP="ゾ", CZ="zo"} },
          { new ZnakDetail{ID=125,znaky=abeceda.Katakana }, new znak {JP="ダ", CZ="da"} },
          { new ZnakDetail{ID=126,znaky=abeceda.Katakana }, new znak {JP="ヂ", CZ="ji"} },
          { new ZnakDetail{ID=127,znaky=abeceda.Katakana}, new znak {JP="ヅ", CZ="dzu"} },
          { new ZnakDetail{ID=128,znaky=abeceda.Katakana}, new znak {JP="デ", CZ="de"} },
          { new ZnakDetail{ID=129,znaky=abeceda.Katakana}, new znak {JP="ド", CZ="do"} },
          { new ZnakDetail{ID=130,znaky=abeceda.Katakana}, new znak {JP="バ", CZ="ba"} },
          { new ZnakDetail{ID=131,znaky=abeceda.Katakana }, new znak {JP="ビ", CZ="bi"} },
          { new ZnakDetail{ID=132,znaky=abeceda.Katakana }, new znak {JP="ブ", CZ="bu"} },
          { new ZnakDetail{ID=133,znaky=abeceda.Katakana}, new znak {JP="ベ", CZ="be"} },
          { new ZnakDetail{ID=134,znaky=abeceda.Katakana}, new znak {JP="ボ", CZ="bo"} },
          { new ZnakDetail{ID=135,znaky=abeceda.Katakana}, new znak {JP="パ", CZ="pa"} },
          { new ZnakDetail{ID=136,znaky=abeceda.Katakana}, new znak {JP="ピ", CZ="pi"} },
          { new ZnakDetail{ID=137,znaky=abeceda.Katakana }, new znak {JP="プ", CZ="pu"} },
          { new ZnakDetail{ID=138,znaky=abeceda.Katakana }, new znak {JP="ペ", CZ="pe"} },
          { new ZnakDetail{ID=139,znaky=abeceda.Katakana}, new znak {JP="ポ", CZ="po"} },



     };
        }

    }
}

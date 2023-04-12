using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Japonstina.vyuka;
using System.Collections.Specialized;

namespace Japonstina.models
{

    public class KanjiModel
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Level")]
        public string KanjiUroven { get; set; }

        [JsonProperty("Type1")]
        public string Typ1 { get; set; }

        [JsonProperty("Type2")]
        public string Typ2 { get; set; }

        [JsonProperty("Kanji")]
        public string KanjiZnak { get; set; }

        [JsonProperty("JP")]
        public string KanjiJp { get; set; }

        [JsonProperty("CZ")]
        public string KanjiCZ { get; set; }


        
       // public ConjugationModel Conjugations { get; set; }
        [JsonProperty("Conjugation")]
        public Dictionary<string, string> Conjugation { get; set; }
    }
}


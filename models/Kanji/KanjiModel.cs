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

        [JsonProperty("Uroven")]
        public string KanjiUroven { get; set; }

        [JsonProperty("Typ1")]
        public string Typ1 { get; set; }

        [JsonProperty("Typ2")]
        public string Typ2 { get; set; }

        [JsonProperty("Kanji")]
        public string KanjiZnak { get; set; }

        [JsonProperty("JP")]
        public string KanjiJp { get; set; }

        [JsonProperty("CZ")]
        public string KanjiCZ { get; set; }


        [JsonProperty("Conjugations")]
        public ConjugationModel Conjugations { get; set; }

        public Dictionary<string, string> Conjugation { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Japonstina.vyuka;

namespace Japonstina.models
{

    public  class KanjiModel
    {
        [JsonProperty("Id")]
        public int KanjiId { get; set; }

        [JsonProperty("Uroven")]
        public string KanjiUroven { get; set; }

        [JsonProperty("Typ1")]
        public string KanjiTyp1 { get; set; }

        [JsonProperty("Typ2")]
        public string KanjiTyp2 { get; set; }

        [JsonProperty("Kanji")]
        public string KanjiZnak { get; set; }

        [JsonProperty("JP")]
        public string KanjiJp { get; set; }

        [JsonProperty("CZ")]
        public string KanjiCZ { get; set; }
    }
}


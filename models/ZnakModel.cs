using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Japonstina.vyuka;

namespace Japonstina.Models
{
    public class ZnakModel
    {
        [JsonProperty("Id")]
        public int ZnakId { get; set; }

        [JsonProperty("Progress")]
        public int ZnakProgress { get; set; }

        [JsonProperty("Completion")]
        public bool ZnakSplneno { get; set; }

        [JsonProperty("Alphabet")]
        public string Abeceda { get; set; }

    }

    public class Vocabulary
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Level")]
        public string Level { get; set; }

        [JsonProperty("KanjiProgress")]
        public long KanjiProgress { get; set; }

        [JsonProperty("KanjiCompletion")]
        public bool KanjiCompletion { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("ConjugationProgress")]
        public long ConjugationProgress { get; set; }

        [JsonProperty("ConjugationCompletion")]
        public bool ConjugationCompletion { get; set; }

    }

}

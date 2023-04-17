using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Japonstina.models;



namespace Japonstina.Models
{
    public class ProgressDataModel
    {
        [JsonProperty("Japanese")]
        public Japanese JapaneseProgress { get; set; }
    };


    public class KanjiDataModel
    {
        [JsonProperty("Japanese")]
        public List<KanjiModel> Data { get; set; }
    }

    public class Japanese
    {
        [JsonProperty("Katakana")]
        public List<Katakana> Katakana { get; set; }

        [JsonProperty("Vocabulary")]
        public List<VocabularyModel> Vocabulary { get; set; }
    }

    public class Katakana
    {
        [JsonProperty("Id")]
        public int KatakanaId { get; set; }

        [JsonProperty("Progress")]
        public int KatakanaProgress { get; set; }

        [JsonProperty("Completion")]
        public bool KatakanaCompletion { get; set; }

        [JsonProperty("Alphabet")]
        public string Alphabet { get; set; }
    }

    public class VocabularyModel
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Level")]
        public string Level { get; set; }

        [JsonProperty("KanjiProgress")]
        public int KanjiProgress { get; set; }

        [JsonProperty("KanjiCompletion")]
        public bool KanjiCompletion { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("ConjugationProgress")]
        public int ConjugationProgress { get; set; }

        [JsonProperty("ConjugationCompletion")]
        public bool ConjugationCompletion { get; set; }
    }




}


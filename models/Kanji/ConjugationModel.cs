using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Japonstina.vyuka;

namespace Japonstina.models
{
    public class ConjugationModel
    {
        [JsonProperty("Present Polite")]
        public string PresentPolite { get; set; }

        [JsonProperty("Present Plain")]
        public string PresentPlain { get; set; }

        [JsonProperty("Volitional Polite")]
        public string VolitionalPolite { get; set; }

        [JsonProperty("Volitional Plain")]
        public string VolitionalPlain { get; set; }

        [JsonProperty("Imperative Polite")]
        public string ImperativePolite { get; set; }

        [JsonProperty("Imperative Plain")]
        public string ImperativePlain { get; set; }

        [JsonProperty("Past Indicative Polite")]
        public string PastIndicativePolite { get; set; }

        [JsonProperty("Past Indivacative Plain")]
        public string PastIndivacativePlain { get; set; }

        [JsonProperty("Past Presumptive Polite")]
        public string PastPresumptivePolite { get; set; }

        [JsonProperty("Past Presumptive Plain")]
        public string PastPresumptivePlain { get; set; }

        [JsonProperty("Present Progressive Plain")]
        public string PresentProgressivePlain { get; set; }

        [JsonProperty("Past Progressive Polite")]
        public string PastProgressivePolite { get; set; }

        [JsonProperty("Past Progressive Plain")]
        public string PastProgressivePlain { get; set; }

        [JsonProperty("Provisional Conditional Polite")]
        public string ProvisionalConditionalPolite { get; set; }

        [JsonProperty("Provisional Conditional Plain")]
        public string ProvisionalConditionalPlain { get; set; }

        [JsonProperty("Conditional Polite")]
        public string ConditionalPolite { get; set; }

        [JsonProperty("Conditional Plain")]
        public string ConditionalPlain { get; set; }

        [JsonProperty("Potential Polite")]
        public string PotentialPolite { get; set; }

        [JsonProperty("Potential Plain")]
        public string PotentialPlain { get; set; }

        [JsonProperty("Causative Polite")]
        public string CausativePolite { get; set; }

        [JsonProperty("Causative Plain")]
        public string CausativePlain { get; set; }
    }
}
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
        //[JsonProperty("Present Polite")]
        //public string PresentPolite { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("PresentPolite")]
        public string PresentPolite { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("PresentPlain")]
        public string PresentPlain { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("VolitionalPolite")]
        public string VolitionalPolite { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("VolitionalPlain")]
        public string VolitionalPlain { get; set; }
    }
}
//Predelat na 1 json. Predelat logiku ze se vezme 1 prvek c oje spravny, k nemu 3 spatne ( kontrola na duplicitu).
//nameof se použiej pouze u spravneho pokud se jedna o slovesa. jinak nameof list nepouzit ( zlobi).
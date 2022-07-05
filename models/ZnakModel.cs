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

        [JsonProperty("Splneno")]
        public bool ZnakSplneno { get; set; }

        [JsonProperty("Abeceda")]
        public string Abeceda { get; set; }
    }
}
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
        [JsonProperty("Znaky")]
        public List<ZnakModel> ProgressZnaku {get; set;}
        };

         public class KanjiDataModel
        {
        [JsonProperty("Znaky")]
        public List<KanjiModel> Data { get; set; }
         }



}


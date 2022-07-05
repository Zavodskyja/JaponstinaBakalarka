using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Japonstina.Models
{
        public class ProgressDataModel
        {
        [JsonProperty("Znaky")]
        public List<ZnakModel> ProgressZnaku {get; set;}
        }



}


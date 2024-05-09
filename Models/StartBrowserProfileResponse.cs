using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinAntyApi.Models
{



    public class StartBrowserProfileResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("wsUrl")]
        public string WsUrl { get; set; }
    }
}

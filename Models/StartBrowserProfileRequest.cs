using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinAntyApi.Models
{

    public class StartBrowserProfileRequest
    {
        [JsonProperty("profileId")]
        public string ProfileId { get; set; }

        [JsonProperty("sync")]
        public bool Sync { get; set; }
    }
}

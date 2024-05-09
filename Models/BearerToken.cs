using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoLoginApi.Models
{
    class BearerToken
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}

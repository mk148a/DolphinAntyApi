using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinAntyApi.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Data
    {
        public long id { get; set; }
    }

    public class CreateBrowserProfileResponse
    {
        public int success { get; set; }
        public long browserProfileId { get; set; }
        public Data data { get; set; }
    }


}

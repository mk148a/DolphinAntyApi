using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoLoginApi.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
  

    public class CreateBrowserProfileResponse
    {
        public string name { get; set; }
        public string role { get; set; }
        public string id { get; set; }
        public string notes { get; set; }
        public string browserType { get; set; }
        public bool lockEnabled { get; set; }
        public Timezone timezone { get; set; }
        public Navigator navigator { get; set; }
        public Geolocation geolocation { get; set; }
        public bool debugMode { get; set; }
        public string os { get; set; }
        public string osSpec { get; set; }
        public Proxy proxy { get; set; }
        public List<object> folders { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public List<object> chromeExtensions { get; set; }
        public List<object> userChromeExtensions { get; set; }
        public bool proxyEnabled { get; set; }
        public bool isBookmarksSynced { get; set; }
        public bool autoLang { get; set; }
        public WebGLMetadata webGLMetadata { get; set; }
        public Fonts fonts { get; set; }
        public FacebookAccountData facebookAccountData { get; set; }
    }

    public class FacebookAccountData
    {
        public NotParsedData notParsedData { get; set; }
    }



    public class Geolocation
    {
        public string mode { get; set; }
        public bool enabled { get; set; }
        public bool customize { get; set; }
        public bool fillBasedOnIp { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public int accuracy { get; set; }
    }



    public class NotParsedData
    {
    }

    public class Proxy
    {
        public string mode { get; set; }
        public int port { get; set; }
        public string autoProxyRegion { get; set; }
        public string torProxyRegion { get; set; }
    }

  
    public class Timezone
    {
        public bool enabled { get; set; }
        public bool fillBasedOnIp { get; set; }
    }

    public class WebGLMetadata
    {
        public string mode { get; set; }
        public string vendor { get; set; }
        public string renderer { get; set; }
    }


}

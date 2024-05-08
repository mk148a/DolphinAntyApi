using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolphinAntyApi.Models
{
   

    public class CreateBrowserProfileRequest
    {
        public long id { get; set; }
        public string name { get; set; }
        public string browserType { get; set; }
        public string platform { get; set; }
        public string platformVersion { get; set; }
        public string mainWebsite { get; set; }
        public Useragent useragent { get; set; }
        public Webrtc webrtc { get; set; }
        public Canvas canvas { get; set; }
        public Webgl webgl { get; set; }
        public WebglInfo webglInfo { get; set; }
        public Locale locale { get; set; }
    }
    public class Canvas
    {
        public string mode { get; set; }
    }

    public class Locale
    {
        public string mode { get; set; }
        public string value { get; set; }
    }

 

    public class Useragent
    {
        public string mode { get; set; }
        public string value { get; set; }
    }

    public class Webgl
    {
        public string mode { get; set; }
    }

    public class WebglInfo
    {
        public string mode { get; set; }
        public string vendor { get; set; }
        public string renderer { get; set; }
    }

    public class Webrtc
    {
        public string mode { get; set; }
    }

}

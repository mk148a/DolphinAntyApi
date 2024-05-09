using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GoLoginApi.Models
{
   

    public class CreateBrowserProfileRequest
    {
        public string name { get; set; }
        public string browserType { get; set; }
        public string os { get; set; }
        public Navigator navigator { get; set; }
        public bool proxyEnabled { get; set; }
        public Proxy proxy { get; set; }
        public Fonts fonts { get; set; }

    }
    public class Fonts
    {
        public List<string> families { get; set; }
        public bool enableMasking { get; set; }
        public bool enableDomRect { get; set; }
    }

    public class Navigator
    {
        public string userAgent { get; set; }
        public string resolution { get; set; }
        public string language { get; set; }
        public string platform { get; set; }
        public bool doNotTrack { get; set; }
        public int hardwareConcurrency { get; set; }
        public int deviceMemory { get; set; }
        public int maxTouchPoints { get; set; }
    }










}

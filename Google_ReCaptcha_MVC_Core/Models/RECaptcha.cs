using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google_ReCaptcha_MVC_Core.Models
{
    public class RECaptcha
    {
        public string Key = "";

        public string Secret = "";
        public string Response { get; set; }
    }

}

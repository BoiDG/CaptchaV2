using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Google_ReCaptcha_MVC_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Google_ReCaptcha_MVC_Core
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new RECaptcha());
        }

        [HttpPost]
        public JsonResult AjaxMethod(string response)
        {
            RECaptcha recaptcha = new RECaptcha();
            string url = "https://www.google.com/recaptcha/api/siteverify?secret=" + recaptcha.Secret + "&response=" + response;
            recaptcha.Response = (new WebClient()).DownloadString(url);
            return Json(recaptcha);
        }
    }
}
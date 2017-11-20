using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private AppConfig appConfig;

        public HomeController(IOptions<AppConfig> appConfig)
        {
            this.appConfig = appConfig.Value;
        }

        public IActionResult Index()
        {
            ViewData["Url"] = appConfig.Url;
            ViewData["Port"] = appConfig.Port;

            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoAppMastek.Controllers
{
    public class ConfigDemoController : Controller
    {
        public IConfiguration Config { get; private set; }

        //public IConfiguration Config { get; private set; }
        public ConfigDemoController(IConfiguration _config)
        {
            Config = _config;
        }
        public IActionResult Index()
        {
            ViewBag.data = Config["CustomKey"];
            return View();
        }
    }
}

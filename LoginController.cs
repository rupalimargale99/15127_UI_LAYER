using Microsoft.AspNetCore.Mvc;
using MVCDemoAppMastek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoAppMastek.Controllers
{
    public class LoginController : Controller
    {
        TrainingContext db;

        public LoginController(TrainingContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
          
            return View(new Userdatum());
        }

        [HttpPost]
        public IActionResult Index(Userdatum user)
        {
            Userdatum obj = db.Userdata.SingleOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            if(obj!=null)
            {
                return RedirectToAction("Index", "Emp");
            }
            else
            {
                ModelState.AddModelError("error", "Invalid username or password");
            }
            return View(user);
        }

    }
}

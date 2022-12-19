using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_NEW.Models;

namespace RMS_NEW.Controllers
{
    public class HomeController : Controller
    {
        db dbop = new db();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind] Ad_login ad)
        {
            if (ModelState.IsValid)
            {

                string res = dbop.LoginCheck(ad);
                TempData["msg"] = res;
                //return RedirectToAction("Index");
            }
            

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }
    }
}

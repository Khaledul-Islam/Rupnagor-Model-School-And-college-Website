using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMSAC.Models;

namespace RMSAC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
        

            return View();
        }
        public IActionResult Notice_board ()
        {


            return View();
        }
        public IActionResult Teachers ()
        {
         

            return View();
        }
        public IActionResult Student()
        {
         

            return View();
        }
        public IActionResult Gallery()
        {
          

            return View();
        }
        public IActionResult Result()
        {
        
        
            return View();
        }
        public IActionResult Science()
        {
        

            return View();
        }
        public IActionResult Commerce()
        {


            return View();
        }
        public IActionResult Arts()
        {


            return View();
        }
        public IActionResult Online_Admission()
        {
         

            return View();
        }


        public IActionResult Events()
        {


            return View();
        }
        public IActionResult Contact()
        {


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

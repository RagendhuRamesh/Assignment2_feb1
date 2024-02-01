using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2_feb1.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult Index()

        {
            ViewBag.msg = "Welcome to Customer List Page";
          
            // Sample list of customer names
            List<string> customerNames = new List<string>
        {
            "Ragendhu Ramesh",
            "Gerard Joshua",
            "Vivek Vincent",
            "Alice Brown"
        };

            // Pass the list to ViewBag
            ViewBag.CustomerNames = customerNames;
            return View();
        }
    }
}
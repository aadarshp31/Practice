using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class MyFirstController : Controller
    {
        // GET: MyFirst
        //The functions/methods below Called as Actions not methods
        public ActionResult Index()
        {
            return View();
        }

        public string Apple()
        {
            return "<input type='text' value='Ooty Apple' />";
        }

        public string Orange()
        {
            return "<h3>Nagpur Orange</h3>";
        }

        // [HttpGet]
        public string Prunes(int id)
        {
            return $"val {id}";
        }

        public string Jack()
        {
            string str = "<form method='post' action='jack/88' ><input type='submit' value='Make a Post Request' /></form>";
            return $"{str}";
        }

        [HttpPost]
        public string Jack(int id)
        {
            return $"Jack = {id}";
        }

        public ViewResult Mango()
        {
            return View();
        }
    }
}
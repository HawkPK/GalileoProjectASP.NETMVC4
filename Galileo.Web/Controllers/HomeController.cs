using Galileo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Galileo.Web.Controllers
{
    public class HomeController : Controller
    {

        private IDepartmentSource _db;

        public HomeController(IDepartmentSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allDepartments = _db.Departments;
            return View(allDepartments);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string HelloPeople()
        {
            return "Hello World";
        }
    }
}
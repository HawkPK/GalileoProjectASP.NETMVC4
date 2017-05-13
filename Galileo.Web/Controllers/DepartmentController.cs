using Galileo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Galileo.Web.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartmentSource _db;

        public DepartmentController(IDepartmentSource db)
        {
            _db = db;
        }
        
        public ActionResult detail(int id)
        {
            var model = _db.Departments.Single(r => r.ID == id);

            return View(model);
        }
    }
}
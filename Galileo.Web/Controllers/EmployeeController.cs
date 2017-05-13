using System.Linq;
using System.Web.Mvc;
using Galileo.Domain;
using Galileo.Web.Models;

namespace Galileo.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDepartmentSource _db;

        public EmployeeController(IDepartmentSource db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Create(int departmentId)
        {
            var model = new CreateEmployeeViewModel();
            model.DepartmentId = departmentId;
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEmployeeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var department = _db.Departments.Single(d => d.ID == viewModel.DepartmentId);
                var employee = new Employee();
                employee.Name = viewModel.Name;
                employee.HireDate = viewModel.HireDate;
                department.Employees.Add(employee);

                _db.Save();

                return RedirectToAction("detail", "Department", new {id = viewModel.DepartmentId});

            }

            return View(viewModel);
        }
    }
}
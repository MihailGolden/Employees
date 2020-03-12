using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployeeList()
        {
            var model = new List<int>();
            return View(model);
        }
    }
}
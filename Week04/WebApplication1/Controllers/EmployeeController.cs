using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core;
using Facade;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var model = new EmployeeListViewModel();
            var employees = Employees.Get();
            var list = new List<EmployeeViewModel>();
            foreach (var e in employees)
            {
                var employee = new EmployeeViewModel(e);
                list.Add(employee);
            }

            model.Employees = list;
            return View("Index", model);
        }
    }
}
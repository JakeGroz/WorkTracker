using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkTracker.Models;

namespace WorkTracker.Controllers
{
    public class HomeController : Controller
    {
        //static HomeDashboard homeDashboard = new HomeDashboard();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HomeDashboard()
        {
            HomeDashboard model = new HomeDashboard();

            Employee e1 = new Employee("1", "Jake", "Groz");
            e1.jobTitle = "IBL Intern";
            Employee e2 = new Employee("2", "Simon", "LS");
            e2.jobTitle = ".net Guy";
            Employee e3 = new Employee("3", "Bailey", "Butley");
            e3.jobTitle = "Intern";
            Employee e4 = new Employee("4", "Sam", "Clarke");
            e4.jobTitle = "Special Kid";

            model.peopleMonitors.Add(e1.empId, e1);
            model.peopleMonitors.Add(e2.empId, e2);
            model.peopleMonitors.Add(e3.empId, e3);
            model.peopleMonitors.Add(e4.empId, e4);



            return View(model);
        }

        public IActionResult AddEmployeeForm()
        {
            return View();
        }

        public IActionResult Privacy()
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

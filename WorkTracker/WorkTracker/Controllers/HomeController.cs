using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using WorkTracker.Models;

namespace WorkTracker.Controllers
{
    public class HomeController : Controller
    {
        static List<Employee> records = new List<Employee>();
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
            HomeController.records.Add(e1);
            Employee e2 = new Employee("2", "Simon", "LS");
            e2.jobTitle = ".net Guy";
            HomeController.records.Add(e2);
            Employee e3 = new Employee("3", "Bailey", "Butley");
            e3.jobTitle = "Intern";
            HomeController.records.Add(e3);
            Employee e4 = new Employee("4", "Sam", "Clarke");
            e4.jobTitle = "Special Kid";
            HomeController.records.Add(e4);

            model.peopleMonitors.Add(e1.empId, e1);
            model.peopleMonitors.Add(e2.empId, e2);
            model.peopleMonitors.Add(e3.empId, e3);
            model.peopleMonitors.Add(e4.empId, e4);

            using (var writer = new StreamWriter("C:\\pathfoldertest\\employeeRecords.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(HomeController.records);
            }

            return View(model);
        }

        public IActionResult AddEmployeeForm()
        {

            Employee e5 = new Employee("5", "XXX", "XXX");
            e5.jobTitle = "XXXX";
            HomeController.records.Add(e5);

            using (var writer = new StreamWriter("C:\\pathfoldertest\\employeeRecords.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(HomeController.records);
            }

            return View();
        }

        public IActionResult AddEmployee(string inp)
        {

            tempz model = new tempz();
            model.testvar = inp;

            return View(model);
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

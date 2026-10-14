using MyFirstApp.Models;
using MyFirstApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int currency)
        {
            var denominations = new List<int>() { 1000, 500, 100, 50, 10, 5, 1 };
            var viewModel = new DenominationViewModel
            {
                Amount = currency
            };


            int remaining = currency;
            foreach(var deno in denominations)
            {
                var lembar = remaining / deno;

                viewModel.ResultDenominations.Add(new DenominationItem
                {
                    Nominal = deno,
                    NumberOfSheets = lembar
                });

                remaining %= deno;
            }
            
            return View(viewModel);
        }

        public ActionResult Products(int? amount)
        {
            ViewBag.Amount = amount;
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GetEmpName(int EmpId)
        {
            var employees = new[] {
                new { EmpId = 1, EmpName = "Scott", Salary = 8000 },
                new { EmpId = 2, EmpName = "Smith", Salary = 2540 },
                new { EmpId = 3, EmpName = "Allen", Salary = 9400 }
            };
            string matchEmpName = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            //return new ContentResult() { Content = matchEmpName, ContentType = "text/plain" };
            return Content(matchEmpName, "text/plain");
        }

        public ActionResult GetPaySlip(int EmpId)
        {
            string fileName = "~/PaySlip" + EmpId + ".pdf";
            return File(fileName, "application/pdf");
        }

        public ActionResult EmpFacebookPage(int EmpId)
        {
            var employees = new[] {
                new { EmpId = 1, EmpName = "Scott", Salary = 8000 },
                new { EmpId = 2, EmpName = "Smith", Salary = 2540 },
                new { EmpId = 3, EmpName = "Allen", Salary = 9400 }
            };
            string fbUrl = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    fbUrl = "http://www.facebook.com/emp" + EmpId;
                }
            }
            if (fbUrl == null)
            {
                return Content("Invalid emp id");
            }
            else
            {
                return Redirect(fbUrl);
            }
        }

        public ActionResult StudentDetails()
        {
            ViewBag.StudentId = 101;
            ViewBag.StudentName = "Scott";
            ViewBag.Marks = 55;
            ViewBag.NoOfSemeters = 6;
            ViewBag.Subjects = new List<string>() { "Physic" ,"Math", "Geologic", "Indonesian Language" };
            return View();
        }
    }
}




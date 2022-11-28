using FinalHamlin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
/***************************************************************
* Name         : FinalHamlin
* Author       : Anthony Hamlin
* Created      : 11/28/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is an MVC Web Application with a StudentWorkerModel that inherits from Student
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace FinalHamlin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.SAL = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FinalHamlin.Models.StudentWorkerModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.SAL = model.WeeklySalary();
                ViewBag.FullName = model.FirstName + " " + model.LastName;
                ViewBag.Salary = ViewBag.SAL.ToString("C2");
            }
            else
            {
                ViewBag.SAL = 0;
                ViewBag.FullName = "";

            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

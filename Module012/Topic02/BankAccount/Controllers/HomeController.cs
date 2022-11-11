using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAccount.Models;

namespace BankAccount.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.EndingBalance = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(BankAccount.Models.BankAccount model)
        {
            if (ModelState.IsValid)
            {
                model.Withdraw();
                ViewBag.EndingBalance = model.Balance;
            }
            else
            {
                ViewBag.EndingBalance = 0;
            }
            return View(model);
        }

    }
}

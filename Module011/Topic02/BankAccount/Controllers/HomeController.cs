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
            model.Withdraw();
            ViewBag.EndingBalance = model.Balance;
            return View(model);
        }
    }
}

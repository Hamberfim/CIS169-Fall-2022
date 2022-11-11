using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LottoNumbersHamlin.Models;
/***************************************************************
* Name         : LottoNumbersHamlin
* Author       : Anthony Hamlin
* Created      : 11/10/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is the controller
*                      Input :  numbers from a html form
*                      Output:  matching numbers
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace LottoNumbersHamlin.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.MatchingNumbers = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(LottoModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.MatchingNumbers = model.CompareTicketToInput();
                ViewBag.Message = model.Message();
            }
            else
            {
                //ViewBag.FirstNumber = 0;
                //ViewBag.SecondNumber = 0;
                //ViewBag.ThirdNumber = 0;
                //ViewBag.FourthNumber = 0;
                ViewBag.MatchingNumbers = 0;
                ViewBag.Message = "";
            }
            return View(model);
        }
    }
}

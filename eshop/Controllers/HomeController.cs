using eshop.Models;
using eshop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using eshop.DataAccess.Models;
using NPOI.SS.Formula.Functions;
using eshop.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace eshop.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork UnitOfWork;
        public HomeController()
        {
            UnitOfWork = new UnitOfWork();
        }
        public IActionResult Index()
        {
            
            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                Market = UnitOfWork.Market.Get(1),
                Title = "Bosh sahifa",
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
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

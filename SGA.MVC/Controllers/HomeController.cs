using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SGA.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private ICargoService cargoService;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //this.cargoService = cargoService;
        }

        public IActionResult Index()
        {
            //CargoViewModel cargoViewModel = (CargoViewModel)cargoService.List();


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

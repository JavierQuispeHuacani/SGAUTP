﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA.MVC.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

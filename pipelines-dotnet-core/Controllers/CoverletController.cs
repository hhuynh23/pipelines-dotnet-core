﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pipelines_dotnet_core.Controllers
{
    public class CoverletController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
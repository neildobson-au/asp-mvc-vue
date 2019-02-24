﻿using Microsoft.AspNetCore.Mvc;
using MVCVue.Models;

namespace MVCVue.Controllers
{
    public class SimpleDropdownUsingTemplatesController : Controller
    {
        public IActionResult Index()
        {
            return View(new CarModel { BrandId = 3});
        }

        [HttpPost]
        public IActionResult Index(CarModel viewModel)
        {
            return RedirectToAction("Index");
        }
    }
}
﻿using Microsoft.AspNetCore.Mvc;

namespace dotnetMvc.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

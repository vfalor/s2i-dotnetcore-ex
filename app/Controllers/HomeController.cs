﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
	    return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        
       public IActionResult privacy()
        {
            return View();
        }
        public IActionResult security()
        {
            return View();
        }
        public IActionResult termsofUse()
        {
            return View();
        }
         public IActionResult returnPolicy()
        {
            return View();
        }
        
	public IActionResult Careers()
        {
            return View();
        }

	public IActionResult Team()
        {
            return View();
        }
	
	public IActionResult Support()
        {
            return View();
        }

	public IActionResult Product()
        {
            return View();
        }
public IActionResult sportswear()
        {
            return View();
        }
	public IActionResult Categary1()
        {
            return View();
        }

	public IActionResult Categary2()
        {
            return View();
        }

	public IActionResult Categary3()
        {
            return View();
        }

	public IActionResult Categary4()
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

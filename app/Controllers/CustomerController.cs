﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
//using System.Mvc;
using Microsoft.AspNetCore.Mvc;
using app.Models;

namespace app.Controllers
{
    public class CustomerController : Controller
    {
	public ActionResult Index()
        {
		ApplicationDbContext applicationDbContext = new ApplicationDbContext();
		List<xxIBM_PRODUCT_STYLE> IBM_PRODUCT_STYLEs = applicationDbContext.xxIBM_PRODUCT_STYLEs.ToList();

		return View(IBM_PRODUCT_STYLEs);
        }

        public ActionResult Details(int id)
        {
		ApplicationDbContext applicationDbContext = new ApplicationDbContext();
		xxIBM_PRODUCT_STYLE IBM_PRODUCT_STYLE = applicationDbContext.xxIBM_PRODUCT_STYLEs.Single(emp => emp.EmployeeId ==id);

		Customer customer = new Customer()
		{
			CustomerId = 101,
			Name = "Rohan",
			Gender = "Male",
			City = "London"
            	};
		return View(customer);
        }

    }
}

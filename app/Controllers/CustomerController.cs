using System;
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
        public ActionResult Details()
        {
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

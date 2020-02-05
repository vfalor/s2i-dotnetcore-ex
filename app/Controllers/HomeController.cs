using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;

using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

List<xxIBM_PRODUCT_STYLEModel> xxIBM_PRODUCT_STYLEs = new List<xxIBM_PRODUCT_STYLEModel>();
        
	string constr = "host=custom-mysql.gamification.svc.cluster.local; port=3306; database=sampledb";
        using (MySqlConnection con = new MySqlConnection(constr))
        {
            string query = "SELECT ITEM_NUMBER, DESCRIPITION, LONG_DESCRIPTION FROM xxIBM_PRODUCT_STYLE";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
               cmd.Connection = con;
               con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        xxIBM_PRODUCT_STYLEs.Add(new xxIBM_PRODUCT_STYLE
                        {
                            ITEM_NUMBER = Convert.ToInt32(sdr["ITEM_NUMBER"]),
                            DESCRIPITION = sdr["DESCRIPITION"].ToString(),
                            LONG_DESCRIPTION = sdr["LONG_DESCRIPTION"].ToString()
                        });
                    }
                }
                con.Close();
            }
        }
            return View(xxIBM_PRODUCT_STYLEs);
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

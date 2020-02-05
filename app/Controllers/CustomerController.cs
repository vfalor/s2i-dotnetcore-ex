using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
//using System.Mvc;
using Microsoft.AspNetCore.Mvc;
using app.Models;

using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace app.Controllers
{
    public class CustomerController : Controller
    {
	public ActionResult Index()
        {

	List<xxIBM_PRODUCT_STYLE> xxIBM_PRODUCT_STYLEs = new List<xxIBM_PRODUCT_STYLE>();
        //string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
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
		
		//using (var context = new ApplicationDbContext())
		//{
		
		//List<xxIBM_PRODUCT_STYLE> IBM_PRODUCT_STYLEs = applicationDbContext.xxIBM_PRODUCT_STYLEs.ToList();


		return View(xxIBM_PRODUCT_STYLEs);
		//}
        }

        public ActionResult Details(int id)
        {
		ApplicationDbContext applicationDbContext = new ApplicationDbContext();
		xxIBM_PRODUCT_STYLE IBM_PRODUCT_STYLE = applicationDbContext.xxIBM_PRODUCT_STYLEs.Single(emp => emp.ITEM_NUMBER ==id);

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

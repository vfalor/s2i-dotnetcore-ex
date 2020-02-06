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
    public class ProductController : Controller
    {
	public ActionResult Index()
        {

	List<ProductModel> productModels = new List<ProductModel>();
        
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
                        productModels.Add(new ProductModel
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
		
		

		
        }

        return View(productModels);
    }
}

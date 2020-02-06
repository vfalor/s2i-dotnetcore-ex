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
    public class PricingController : Controller
    {
	public ActionResult Index(string id)
        {

	List<PRODUCT_PRICING> pricingModels = new List<PRODUCT_PRICING>();
        
	string constr = "host=custom-mysql.gamification.svc.cluster.local; port=3306; database=sampledb; uid=xxuser; pwd=welcome1;";
        using (MySqlConnection con = new MySqlConnection(constr))
        {
            string query = "SELECT * FROM XXIBM_PRODUCT_PRICING ";

	    if(id != null)
		query += " where LIST_PRICE like '%"+id+"%' or ITEM_NUMBER like '%"+id+"%' or DISCOUNT like '%"+id+"%' ";

            using (MySqlCommand cmd = new MySqlCommand(query))
            {
               cmd.Connection = con;
               con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        pricingModels.Add(new PRODUCT_PRICING
                        {
			    PRICE_ID = Convert.ToInt32(sdr["PRICE_ID"]),
                            ITEM_NUMBER = Convert.ToInt32(sdr["ITEM_NUMBER"]),
                            LIST_PRICE = float.Parse(sdr["LIST_PRICE"]),
                            DISCOUNT = float.Parse(sdr["DISCOUNT"]),
			    IN_STOCK = sdr["IN_STOCK"].ToString()

                        });
                    }
                }
                con.Close();
            }
        }
		
		

	return View(pricingModels);	
        }

        
    }
}

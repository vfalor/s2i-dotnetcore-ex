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
    public class ProductCatalogController : Controller
    {
	public ActionResult Index(string id)
        {

	List<PRODUCT_CATALOG> productCatalogs = new List<PRODUCT_CATALOG>();
        
	string constr = "host=custom-mysql.gamification.svc.cluster.local; port=3306; database=sampledb; uid=xxuser; pwd=welcome1;";
        using (MySqlConnection con = new MySqlConnection(constr))
        {
            //string query = "SELECT SEGMENT,SEGMENT_NAME,FAMILY,FAMILY_NAME,CLASS,CLASS_NAME,COMMODITY,COMMODITY_NAME FROM XXIBM_PRODUCT_CATALOGUE ";
	    string query = "SELECT * FROM XXIBM_PRODUCT_CATALOGUE ";

	    if(id != null)
		query += " where COMMODITY_NAME like '%"+id+"%' or FAMILY_NAME like '%"+id+"%' or CLASS_NAME like '%"+id+"%' or CLASS like '%"+id+"%' ";

            using (MySqlCommand cmd = new MySqlCommand(query))
            {
               cmd.Connection = con;
               con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        productCatalogs.Add(new PRODUCT_CATALOG
                        {
                            SEGMENT = Convert.ToInt32(sdr["SEGMENT"]),
                            SEGMENT_NAME = sdr["SEGMENT_NAME"].ToString(),
                            FAMILY = Convert.ToInt32(sdr["FAMILY"]),
                            FAMILY_NAME = sdr["FAMILY_NAME"].ToString(),
                            CLASS = Convert.ToInt32(sdr["CLASS"]),
                            CLASS_NAME = sdr["CLASS_NAME"].ToString(),
                            COMMODITY = Convert.ToInt32(sdr["COMMODITY"]),
                            COMMODITY_NAME = sdr["COMMODITY_NAME"].ToString(),
                        });
                    }
                }
                con.Close();
            }
        }
		
		

	return View(productCatalogs);	
        }

        
    }
}

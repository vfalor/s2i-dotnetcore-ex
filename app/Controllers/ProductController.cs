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
	public ActionResult Index(string strSearch)
        {

	List<ProductModel> productModels = new List<ProductModel>();
        
	string constr = "host=custom-mysql.gamification.svc.cluster.local; port=3306; database=sampledb; uid=xxuser; pwd=welcome1;";
        using (MySqlConnection con = new MySqlConnection(constr))
        {
            //string query = "SELECT ITEM_NUMBER, DESCRIPTION, LONG_DESCRIPTION FROM XXIBM_PRODUCT_STYLE ";
            //string query = "SELECT table_schema from information_schema.TABLES GROUP BY table_schema";
	    string query = "SELECT table_name FROM information_schema.tables WHERE table_type = 'base table' AND table_schema='sampledb'";

	    if(strSearch != null)
		query += " where DESCRIPTION like '%"+strSearch+"%' ";

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
                            ITEM_NUMBER = 1, //Convert.ToInt32(sdr["ITEM_NUMBER"]),
                            DESCRIPTION = sdr["table_name"].ToString(),//sdr["DESCRIPTION"].ToString(),
                            LONG_DESCRIPTION = sdr["table_name"].ToString()//sdr["LONG_DESCRIPTION"].ToString()
                        });
                    }
                }
                con.Close();
            }
        }
		
		

	return View(productModels);	
        }

        
    }
}

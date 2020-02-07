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
    public class ProductSkuController : Controller
    {
	public ActionResult Index(string id)
        {

	List<PRODUCT_SKU> ProductSkuModels = new List<PRODUCT_SKU>();
        
	string constr = "host=custom-mysql.gamification.svc.cluster.local; port=3306; database=sampledb; uid=xxuser; pwd=welcome1;";
        using (MySqlConnection con = new MySqlConnection(constr))
        {
            string query = "SELECT * FROM XXIBM_PRODUCT_SKU ";

	    if(id != null)
		query += " where ITEM_NUMBER like '%"+id+"%' or DESCRIPTION like '%"+id+"%' or LONG_DESCRIPTION like '%"+id+"%' or SKU_UNIT_OF_MEASURE like '%"+id+"%' or SKU_ATTRIBUTE1 like '%"+id+"%' or SKU_ATTRIBUTE_VALUE1 like '%"+id+"%'";

            using (MySqlCommand cmd = new MySqlCommand(query))
            {
               cmd.Connection = con;
               con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        ProductSkuModels.Add(new PRODUCT_SKU
                        {
			    
                            ITEM_NUMBER = Convert.ToInt32(sdr["ITEM_NUMBER"]),
                            DESCRIPTION = sdr["DESCRIPTION"].ToString(),
                            LONG_DESCRIPTION = sdr["LONG_DESCRIPTION"].ToString(),
			    CATALOGUE_CATEGORY = Convert.ToInt32(sdr["CATALOGUE_CATEGORY"]),
			    SKU_UNIT_OF_MEASURE = sdr["SKU_UNIT_OF_MEASURE"].ToString(),
			    STYLE_ITEM = Convert.ToInt32(sdr["STYLE_ITEM"]),
			    SKU_ATTRIBUTE_1 = sdr["SKU_ATTRIBUTE1"].ToString(),
			    SKU_ATTRIBUTE_2 = sdr["SKU_ATTRIBUTE2"].ToString(),
			    SKU_ATTRIBUTE_3 = sdr["SKU_ATTRIBUTE3"].ToString(),
			    SKU_ATTRIBUTE_4 = sdr["SKU_ATTRIBUTE4"].ToString(),
			    SKU_ATTRIBUTE_5 = sdr["SKU_ATTRIBUTE5"].ToString(),
			    SKU_ATTRIBUTE_6 = sdr["SKU_ATTRIBUTE6"].ToString(),
			    SKUATT_VALUE_1 = sdr["SKU_ATTRIBUTE_VALUE1"].ToString(),
			    SKUATT_VALUE_2 = sdr["SKU_ATTRIBUTE_VALUE2"].ToString(),
			    SKUATT_VALUE_3 = sdr["SKU_ATTRIBUTE_VALUE3"].ToString(),
			    SKUATT_VALUE_4 = sdr["SKU_ATTRIBUTE_VALUE4"].ToString(),
			    SKUATT_VALUE_5 = sdr["SKU_ATTRIBUTE_VALUE5"].ToString(),
			    SKUATT_VALUE_6 = sdr["SKU_ATTRIBUTE_VALUE6"].ToString()
                        });
                    }
                }
                con.Close();
            }
        }
		
		

	return View(ProductSkuModels);	
        }

        
    }
}

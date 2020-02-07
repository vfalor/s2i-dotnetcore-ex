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
    public class TableController : Controller
    {
	public ActionResult Index(string id)
        {

	List<TableModel> tableModels = new List<TableModel>();
        
	string constr = "host=custom-mysql.gamification.svc.cluster.local; port=3306; database=sampledb; uid=xxuser; pwd=welcome1;";
        using (MySqlConnection con = new MySqlConnection(constr))
        {
            //string query = "SELECT table_schema from information_schema.TABLES GROUP BY table_schema";
	    string query = "SELECT table_name AS NAME FROM information_schema.tables WHERE table_type = 'base table' AND table_schema='sampledb' ";

	    if(id != null)
		query = "SELECT COLUMN_NAME AS NAME FROM information_schema.columns WHERE table_schema='sampledb' AND table_name='"+id+"' ";
		//AND COLUMN_NAME LIKE '[wildcard]'

            using (MySqlCommand cmd = new MySqlCommand(query))
            {
               cmd.Connection = con;
               con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        tableModels.Add(new TableModel
                        {
                            ITEM_NUMBER = 1, 
                            TABLE_NAME = sdr["NAME"].ToString()
                        });
                    }
                }
                con.Close();
            }
        }
		
		

	return View(tableModels);	
        }

        
    }
}

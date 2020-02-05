using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace app.Models
{
    public class xxIBM_PRODUCT_STYLEModel
    {
        [Key]
	public int ITEM_NUMBER {get; set;}
	public String DESCRIPITION {get; set;}
	public String LONG_DESCRIPTION {get; set;}
	public int CATALOGUE_CATEGORY {get; set;}
	public String BRAND {get; set;}


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class xxIBM_PRODUCT_SKU
    {
        [Key]
	public int ITEM_NUMBER {get; set;}

    }

    public class xxIBM_PRODUCT_PRICING
    {
        [Key]
	public int ITEM_NUMBER {get; set;}

    }

    public class xxIBM_PRODUCT_CATALOGUE
    {
        [Key]
	public int ITEM_NUMBER {get; set;}

    }

    public class xxIBM_PRODUCT_STYLE
    {
        [Key]
	public int ITEM_NUMBER {get; set;}
	public String DESCRIPITION {get; set;}
	public String LONG_DESCRIPTION {get; set;}
	public int CATALOGUE_CATEGORY {get; set;}
	public String BRAND {get; set;}


    }
}
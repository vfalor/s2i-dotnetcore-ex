using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class ProductModel
    {
        [Key]
	public int ITEM_NUMBER {get; set;}
	public String DESCRIPTION {get; set;}
	public String LONG_DESCRIPTION {get; set;}
	public int CATALOGUE_CATEGORY {get; set;}
	public String BRAND {get; set;}
    }
}
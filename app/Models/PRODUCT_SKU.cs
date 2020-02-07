using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class PRODUCT_SKU
    {
        [Key]
	public int ITEM_NUMBER {get; set;}
	public String DESCRIPTION {get; set;}
	public String LONG_DESCRIPTION {get; set;}
	public int CATALOG_CATEGORY {get; set;}
  	public String SKU_UNIT_OF_MEASURE {get; set;}
  	public int STYLE_ITEM {get; set;}
  	public String SKU_ATTRIBUTE_1 {get; set;}
  	public String SKU_ATTRIBUTE_2 {get; set;}
  	public String SKU_ATTRIBUTE_3 {get; set;}
  	public String SKU_ATTRIBUTE_4 {get; set;}
  	public String SKU_ATTRIBUTE_5 {get; set;}
  	public String SKU_ATTRIBUTE_6 {get; set;}
	public String SKUATT_VALUE_1 {get; set;}
  	public String SKUATT_VALUE_2 {get; set;}
  	public String SKUATT_VALUE_3 {get; set;}
  	public String SKUATT_VALUE_4 {get; set;}
  	public String SKUATT_VALUE_5 {get; set;}
  	public String SKUATT_VALUE_6 {get; set;}
    }
}

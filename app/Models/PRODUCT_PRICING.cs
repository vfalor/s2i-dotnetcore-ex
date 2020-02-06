using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class PRODUCT_PRICING
    {
        [Key]
	public int PRICE_ID {get; set;}
	public int ITEM_NUMBER {get; set;}
  public int LIST_PRICE {get; set;}
  public int DISCOUNT {get; set;}
  public String IN_STOCK {get; set;}
  public int PRICE_EFFECTIVE_DATE {get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class Pricing
    {
        [Key]
	public int PRICE_ID {get; set;}
	public int ITEM_NUMBER {get; set;}
  public float LIST_PRICE {get; set;}
  public float DISCOUNT {get; set;}
  public String IN_STOCK {get; set;}
  public int PRICE_EFFECTIVE_DATE {get; set;}
    }
}

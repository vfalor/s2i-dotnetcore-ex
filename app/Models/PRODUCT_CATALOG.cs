using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class PRODUCT_CATALOG
    {
        [Key]
	public int SEGMENT {get; set;}
	public String SEGMENT_NAME {get; set;}
	public int FAMILY {get; set;}
  public String FAMILY_NAME {get; set;}
  public int CLASS {get; set;}
  public String CLASS_NAME {get; set;}
	public int COMMODITY{get; set;}
	public String COMMODITY_NAME {get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class TableModel
    {
        [Key]
	public int ITEM_NUMBER {get; set;}
	public String TABLE_NAME {get; set;}
    }
}
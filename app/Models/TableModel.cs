using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    public class TableModel
    {
        [Key]
	public String TABLE_NAME {get; set;}
	public String COLUMN_NAME {get; set;}
    }
}
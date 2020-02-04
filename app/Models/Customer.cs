using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace app.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }

        //public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
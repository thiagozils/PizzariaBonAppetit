using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaBonAppetit.Models
{
    public class Order
    {

        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public bool IsDone { get; set; }


        


    }
}
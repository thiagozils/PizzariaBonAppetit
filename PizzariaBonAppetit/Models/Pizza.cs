using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaBonAppetit.Models
{
    public class Pizza
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public double Prize { get; set; }
        public bool HaveEdge { get; set; }


    }
}
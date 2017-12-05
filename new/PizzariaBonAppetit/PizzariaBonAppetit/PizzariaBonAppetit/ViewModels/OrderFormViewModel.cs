using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzariaBonAppetit.Models;

namespace PizzariaBonAppetit.ViewModels
{
    public class OrderFormViewModel
    {

        public IEnumerable<Pizza> Pizzas { get; set; }

        public IEnumerable<Customer> Customers { get; set; }

        public IEnumerable<Size> Sizes { get; set; }

        public Order Order { get; set; }
        public string Title
        {
            get
            {
                if (Order != null && Order.Id != 0)
                    return "Editar ordem";

                return "Nova ordem";
            }
        }


    }
}
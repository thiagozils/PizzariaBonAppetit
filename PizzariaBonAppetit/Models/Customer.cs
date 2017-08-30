using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaBonAppetit.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer()
        {

        }

        public Customer(int Id, string CPf , string Name, string Address)
        {
            this.Id = Id;
            this.Cpf = Cpf;
            this.Name = Name;
            this.Address = Address;
        }



    }
}
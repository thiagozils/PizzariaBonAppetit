using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzariaBonAppetit.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee (int Id, string CPf, string Name, double Salary)
        {
            this.Id = Id;
            this.Cpf = Cpf;
            this.Name = Name;
            this.Salary = Salary;
        }




    }
}
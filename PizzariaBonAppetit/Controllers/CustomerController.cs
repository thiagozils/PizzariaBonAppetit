using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzariaBonAppetit.Models;

namespace PizzariaBonAppetit.Controllers
{
    public class CustomerController : Controller
    {
      //  public List<Customer> pizzas = new List<Pizza>
        //    {
              //  new Customer {Name = "Aracy de Freitas", Id = 1 , Cpf= "120.345.768-00", Address = "Jaraguá do Sul"},

          //  };



        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
    }
}
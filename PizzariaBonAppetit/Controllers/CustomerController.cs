using System.Collections.Generic;
using System.Web.Mvc;
using PizzariaBonAppetit.Models;
using PizzariaBonAppetit.ViewModels;

namespace PizzariaBonAppetit.Controllers
{
    public class CustomerController : Controller
    {
        public List<Customer> clientes = new List<Customer>
            {
                new Customer {Name = "Aracy de Freitas", Id = 1 , Cpf= "120.345.768-00", Address = "Jaraguá do Sul"},
                new Customer {Name = "Thiago Andrey Zils", Id = 2 , Cpf= "120.345.760-00", Address = "Schroeder"},
                new Customer {Name = "Katy Perry", Id = 3 , Cpf= "120.345.768-90", Address = "Califórnia"}

            };



        // GET: Customer
        public ActionResult Index()
        {
            var Clientes = new CustomerIndexViewModel()
            {
                Customers = clientes
            };
            return View(Clientes);
        }

        public ActionResult Details( int id)
        {
            if (clientes.Count < 0)
            {
                return HttpNotFound();
            }


            Customer cliente = clientes[id-1];
            return View(cliente);
        }


    }
}
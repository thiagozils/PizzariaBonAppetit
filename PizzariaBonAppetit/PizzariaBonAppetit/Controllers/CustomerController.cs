using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using PizzariaBonAppetit.Models;
using PizzariaBonAppetit.ViewModels;

namespace PizzariaBonAppetit.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        
        public ActionResult Index()
        {

            var viewModel = _context.Customers.ToList() ;
            return View(viewModel);

           
        }

        public ActionResult Details(int id)
        {
            var viewModel = _context.Customers.Find(id);
            return View(viewModel);
        }


        public ActionResult New()
        {
            var viewModel = new Customer();
            ViewBag.Title = "Novo cliente";
            return View("CustomerForm", viewModel);

        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            ViewBag.Title = "Editar cliente";
            if (customer == null)
                return HttpNotFound();

            

            return View("CustomerForm", customer);
        }






        [HttpPost] // só será acessada com POST
        public ActionResult Save(Customer customer) // recebemos um cliente
        {
            if (!ModelState.IsValid)
            {
                return View("CustomerForm", customer);
            }

            

            if (customer.Id == 0){
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Cpf = customer.Cpf;
                customerInDb.Address = customer.Address;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
            return new HttpStatusCodeResult(200);
        }


    }
}
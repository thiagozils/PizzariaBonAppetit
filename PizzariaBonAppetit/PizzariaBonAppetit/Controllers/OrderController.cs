using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PizzariaBonAppetit.Models;
using PizzariaBonAppetit.ViewModels;

namespace PizzariaBonAppetit.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _context;

        public OrderController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: Order
        public ActionResult Index()
        {

            var viewModel = _context.Orders.ToList();
            return View(viewModel);


        }

        public ActionResult Details(int id)
        {
            var viewModel = _context.Orders.Include(a => a.Pizza).Include(a => a.Customer).Include(a => a.Size).SingleOrDefault(a => a.Id == id) ;
            return View(viewModel);
        }

        public ActionResult New()
        {
            var pizzas = _context.Pizzas.ToList();
            var sizes = _context.Sizes.ToList();
            var customers = _context.Customers.ToList();
            var viewModel = new OrderFormViewModel
            {
                Order = new Order(),
                Pizzas = pizzas,
                Sizes = sizes,
                Customers = customers
            };

            return View("OrderForm", viewModel);
        }

        [HttpPost] // só será acessada com POST
        [ValidateAntiForgeryToken]
        public ActionResult Save(Order order) // recebemos um cliente
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new OrderFormViewModel
                {
                    Order = order,
                    Pizzas = _context.Pizzas.ToList(),
                    Customers = _context.Customers.ToList(),
                    Sizes = _context.Sizes.ToList()
                };

                return View("OrderForm", viewModel);
            }

            if (order.Id == 0)
            {
                // armazena o cliente em memória
                _context.Orders.Add(order);
            }
            else
            {
                var orderInDb = _context.Orders.Single(c => c.Id == order.Id);

                orderInDb.Description = order.Description;
                orderInDb.IsDone = order.IsDone;
                orderInDb.PizzaId = order.PizzaId;
                orderInDb.SizeId = order.SizeId;
                orderInDb.CustomerId = order.CustomerId;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var order = _context.Orders.SingleOrDefault(c => c.Id == id);

            if (order == null)
                return HttpNotFound();

            var viewModel = new OrderFormViewModel
            {
                Order = order,
                Pizzas = _context.Pizzas.ToList(),
                Customers = _context.Customers.ToList(),
                Sizes = _context.Sizes.ToList()
            };

            return View("OrderForm", viewModel);
        }
    }
}


 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzariaBonAppetit.Models;
using PizzariaBonAppetit.ViewModels;

namespace PizzariaBonAppetit.Controllers
{
    public class PizzaController : Controller
    {

        private ApplicationDbContext _context;

        public PizzaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public ActionResult Index()
        {


            var viewModel = _context.Pizzas.ToList();

            return View(viewModel);

        }

        public ActionResult Details(int id)
        {

            var viewModel = _context.Pizzas.Find(id);
            return View(viewModel);
        }



        public ActionResult New()
        {
            var pizza = new Pizza();
            ViewBag.Title = "Nova pizza";
            return View("PizzaForm", pizza);

        }

        public ActionResult Edit(int id)
        {
            var pizza = _context.Pizzas.SingleOrDefault(c => c.Id == id);
            ViewBag.Title = "Editar pizza";
            if (pizza == null)
                return HttpNotFound();

            return View("PizzaForm", pizza);
        }






        [HttpPost] // só será acessada com POST
        public ActionResult Save(Pizza pizza) // recebemos um cliente
        {
            if (!ModelState.IsValid)
            {
                return View("PizzaForm", pizza);
            }



            if (pizza.Id == 0)
            {
                _context.Pizzas.Add(pizza);
            }
            else
            {
                var pizzaInDb = _context.Pizzas.Single(c => c.Id == pizza.Id);
                pizzaInDb.Name = pizza.Name;
                pizzaInDb.Prize = pizza.Prize;
                pizzaInDb.Description = pizza.Description;

            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzariaBonAppetit.Models;

namespace PizzariaBonAppetit.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {

            var pizza = new Pizza()
            {
                Id = 1,
                Name = "4 Queijos",
                Prize = 30.0,
                HaveEdge = true

            };
            return View(pizza);



        }
    }
}
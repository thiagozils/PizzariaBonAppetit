﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzariaBonAppetit.Models;

namespace PizzariaBonAppetit.Controllers
{
    public class PizzaController : Controller
    {

        public List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza {Name = "4Queijos", Id = 1 , Prize= 22.50, HaveEdge = true},
            new Pizza {Name = "Bacon", Id = 2, Prize= 30.65, HaveEdge = true},
            new Pizza {Name = "Calabresa", Id = 3, Prize= 12.2, HaveEdge = false},
            new Pizza {Name = "Brocólis", Id = 4, Prize= 15.69, HaveEdge = true}
        };


        // GET: Pizza
        public ActionResult Index()
        {

            return View(Pizzas);



        }
    }
}
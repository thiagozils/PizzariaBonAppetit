using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzariaBonAppetit.Models;
namespace PizzariaBonAppetit.Controllers

{
    public class SizeController : Controller
    {
        private ApplicationDbContext _context;

        public SizeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: Size
        public ActionResult Index()
        {
            var viewModel = _context.Sizes.ToList();
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var viewModel = _context.Sizes.Find(id);
            return View(viewModel);
        }

        public ActionResult New()
        {
            var viewModel = new Size();
            ViewBag.Title = "Novo tamanho";
            return View("SizeForm", viewModel);

        }

        public ActionResult Edit(int id)
        {
            var size = _context.Sizes.SingleOrDefault(c => c.Id == id);
            ViewBag.Title = "Editar tamanho";
            if (size == null)
                return HttpNotFound();

            return View("SizeForm", size);
        }


        [HttpPost] // só será acessada com POST
        public ActionResult Save(Size size) // recebemos um cliente
        {
            if (!ModelState.IsValid)
            {
                return View("SizeForm", size);
            }



            if (size.Id == 0)
            {
                _context.Sizes.Add(size);
            }
            else
            {
                var sizeInDb = _context.Sizes.Single(c => c.Id == size.Id);
                sizeInDb.Name = size.Name;
                sizeInDb.Prize = size.Prize;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }




    }
}
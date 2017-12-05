using PizzariaBonAppetit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzariaBonAppetit.Controllers
{
    public class EmployeeController : Controller
    {

        private ApplicationDbContext _context;

        public EmployeeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ActionResult Index()
        {

            var viewModel = _context.Employees.ToList();
            return View(viewModel);


        }

        public ActionResult Details(int id)
        {

            var viewModel = _context.Employees.Find(id);
            return View(viewModel);


        }


        public ActionResult New()
        {
            var viewModel = new Employee();
            ViewBag.Title = "Novo funcionário";
            return View("EmployeeForm", viewModel);

        }

        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(c => c.Id == id);
            ViewBag.Title = "Editar funcionário";
            if (employee == null)
                return HttpNotFound();

            return View("EmployeeForm", employee);
        }


        [HttpPost] // só será acessada com POST
        public ActionResult Save(Employee employee) // recebemos um cliente
        {
            if (!ModelState.IsValid)
            {
                return View("EmployeeForm", employee);
            }



            if (employee.Id == 0)
            {
                _context.Employees.Add(employee);
            }
            else
            {
                var employeeInDb = _context.Employees.Single(c => c.Id == employee.Id);
                employeeInDb.Name = employee.Name;
                employeeInDb.Cpf = employee.Cpf;
                employeeInDb.Salary = employee.Salary;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

    }




}

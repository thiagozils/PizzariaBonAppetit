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


        [AllowAnonymous]
        public ActionResult Index()
        {

            var viewModel = _context.Employees.ToList();
            if (User.IsInRole(RoleName.CanManageCustomers))
                return View(viewModel);
            return View("ReadOnlyIndex", viewModel);


        }
        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult Details(int id)
        {

            var viewModel = _context.Employees.Find(id);
            return View(viewModel);


        }

        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult New()
        {
            var viewModel = new Employee();
            ViewBag.Title = "Novo funcionário";
            return View("EmployeeForm", viewModel);

        }
        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(c => c.Id == id);
            ViewBag.Title = "Editar funcionário";
            if (employee == null)
                return HttpNotFound();

            return View("EmployeeForm", employee);
        }

        [Authorize(Roles = RoleName.CanManageCustomers)]
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
        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult Delete(int id)
        {
            var func = _context.Employees.SingleOrDefault(c => c.Id == id);
            if (func == null)
            {
                return HttpNotFound();
            }
            else
            {
                _context.Employees.Remove(func);
                _context.SaveChanges();
            }
            return new HttpStatusCodeResult(200);
        }



    }




}

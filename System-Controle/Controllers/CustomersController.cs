using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System_Controle.Models;
using System.Data.Entity;
using System_Controle.ViewModels;

namespace System_Controle.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _DbContext;
        public CustomersController()//ctor
        {
            _DbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _DbContext.Dispose();
            base.Dispose(disposing);
        }
        private IEnumerable<Customer> GetCustomers()
        {


            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
        // GET: Customers
        public ActionResult Index()
        {

            //var customers = _vidlyDbContext.Customers.Include(c => c.MembershipType).ToList();
            //GetCustomers(); defer excution using System.Data.Entity;

            return View();
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            var customerName = _DbContext.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);//GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customerName == null)
                return HttpNotFound();
            else
                return View(customerName);
        }

        public ActionResult Edit(int id)
        {
            var customerName = _DbContext.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);//GetCustomers().SingleOrDefault(c => c.Id == id);
            var membershipType = _DbContext.MembershipType.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                Customer = customerName,
                MembershipTypes = membershipType
            };
            if (customerName == null)
                return HttpNotFound();
            else
                return View("CustomerForm", viewModel);
        }
        public ActionResult New()
        {
            var membershipType = _DbContext.MembershipType.ToList();
            var newCustomerViewModel = new CustomerFormViewModel()
            {
                Customer = new Customer(),
                MembershipTypes = membershipType
            };
            //ViewBag.membershipType = membershipType;
            return View("CustomerForm", newCustomerViewModel);
        }
        // GET: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var newCustomerViewModel = new CustomerFormViewModel()
                {
                    Customer = customer,
                    MembershipTypes = _DbContext.MembershipType.ToList()
                };
                return View("CustomerForm", newCustomerViewModel);
            }
            else
            {
                if (customer.Id == 0)
                    _DbContext.Customers.Add(customer);
                else
                {
                    var customerInDb = _DbContext.Customers.Single(c => c.Id == customer.Id);
                    //TryUpdateModel(customerInDb,"", new string[] { "Email","Date"});
                    //AutoMapper//UpdateCustomerDto
                    //Mapper.Map(customer,customerInDb);
                    customerInDb.Name = customer.Name;
                    customerInDb.Birthdate = customer.Birthdate;
                    customerInDb.MembershipTypeId = customer.MembershipTypeId;
                    customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

                }
                _DbContext.SaveChanges();
                return RedirectToAction("Index", "Customers");

            }

        }



    }
}

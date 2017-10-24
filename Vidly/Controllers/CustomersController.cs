using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Customer 1" },
                new Customer {Id = 2, Name = "Customer 2" }
            };

            var viewmodel = new AllCustomersViewModel
            {
                Customers = customers
            };

            return View(viewmodel);
        }


        public ActionResult Details(int Id)
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Customer 1" },
                new Customer {Id = 2, Name = "Customer 2" }
            };
            bool isinlist = false;
            string name = "";
            foreach (var customer in customers)
            {
                if(customer.Id == Id)
                {
                    isinlist = true;
                    name = customer.Name;
                }
            }
            if (isinlist == true)
            {
                return Content(name);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}
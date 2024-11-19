using CustomerManagementWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CustomerManagementWebApp.Controllers
{
    public class CustomerController : Controller
    {
        private static List<Customer> customers = new List<Customer>();

        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.Id = customers.Count + 1;
                customers.Add(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        public IActionResult Delete(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                customers.Remove(customer);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Capstone.Data;
using Capstone.Models;
using Capstone.ActionFilters;

namespace Capstone.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomerController : Controller
    {

        private ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: Customers


        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _db.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault();

            if (customer == null)
            {
                return RedirectToAction(nameof(Create));
            }

            customer = await _db.Customer
           //.Include(c => c.Car)
           .Include(c => c.IdentityUser)
           .FirstOrDefaultAsync(m => m.Id == customer.Id);

            return View(customer);

            //var applicationDbContext = _context.Customers.Include(c => c.Car).Include(c => c.IdentityUser);
            //return View(await applicationDbContext.ToListAsync());
        }


        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var customer = await _db.Customer
                //.Include(c => c.Car)
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customer/Create

        public IActionResult Create()
        {

            ViewData["IdentityUserId"] = new SelectList(_db.Users, "Id", "Id");
            return View();


        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,EmailAddress,PhoneNumber,HomeAddresss,City,State,ZipCode")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;

                _db.Add(customer);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_db.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            Customer editCustomer = _db.Customer.Find(id);
            return View(editCustomer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            try
            {
                _db.Customer.Update(customer);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            Customer deleteCustomer = _db.Customer.Find(id);
            return View(deleteCustomer);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                Customer deleteCustomer = _db.Customer.Find(id);
                _db.Customer.Remove(deleteCustomer);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

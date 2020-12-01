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
using Capstone.Services; 

namespace Capstone.Controllers
{ 
    public class NeighborController : Controller
    {

        private readonly ApplicationDbContext _db;
        private readonly IGeoCodingService _geocodingService; 
        public NeighborController(ApplicationDbContext db, IGeoCodingService geoCodingService)
        {
            _db = db;
            _geocodingService = geoCodingService; 
        }

        // GET: Neighbors
        
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var neighbor = _db.Neighbors.Where(m => m.IdentityUserId == userId).FirstOrDefault();

            if (neighbor == null)
            {
                return RedirectToAction(nameof(Create));
            }

            neighbor = await _db.Neighbors
                .Include(c => c.IdentityUser)
                .Include(c => c.Location)
                .FirstOrDefaultAsync(m => m.Id == neighbor.Id);
             
            return View(neighbor);

        }


        // GET: Neighbor/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var neighbor = await _db.Neighbors
                //.Include(c => c.Car)
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (neighbor == null)
            {
                return NotFound();
            }

            return View(neighbor);
        }

        // GET: Neighbor/Create

        public IActionResult Create()
        {

            ViewData["IdentityUserId"] = new SelectList(_db.Users, "Id", "Id");
            return View();


        }

        // POST: Neighbor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,EmailAddress,PhoneNumber,HomeAddresss,City,State,ZipCode")] Neighbor neighbor)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                neighbor.IdentityUserId = userId;

                _db.Add(neighbor);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_db.Users, "Id", "Id", neighbor.IdentityUserId);
            return View(neighbor);
        }

        // GET: Neighbor/Edit/5
        public ActionResult Edit(int id)
        {
            Neighbor editNeighbor = _db.Neighbors.Find(id);
            return View(editNeighbor);
        }

        // POST: Neighbor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Neighbor neighbor)
        {
            try
            {
                _db.Neighbors.Update(neighbor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: Neighbor/Delete/5
        public ActionResult Delete(int id)
        {
            Neighbor deleteNeighbor = _db.Neighbors.Find(id);
            return View(deleteNeighbor);
        }

        // POST: Neighbor/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Neighbor neighbor)
        {
            try
            {
                Neighbor deleteNeighbor = _db.Neighbors.Find(id);
                _db.Neighbors.Remove(deleteNeighbor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Location()
        {

            var location = _db.Location; 

            if (location.Any() == false)
            {
                return RedirectToAction(nameof(CreateLocation)); 
            }

            return View(location);
        }

      
        public IActionResult CreateLocation()
        {
            //ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLocation([Bind("FirstName, LastName, Address, City, State, ZipCode")] Location location)
        {
            if (ModelState.IsValid)
            {
                //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                //var neighbor = _db.Neighbors.Where(c => c.IdentityUserId == userId).SingleOrDefault();

                location = await _geocodingService.AttachLatAndLong(location);

                
                //location.OwnerId = neighbor.Id;
                _db.Location.Add(location);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Location));
            }
     
            return View(location);
        }
        public ActionResult Home()
        {
            return View(); 
        }

    }
}

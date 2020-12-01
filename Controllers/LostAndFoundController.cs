using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Capstone.Models;
using Capstone.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Capstone.Controllers
{
    public class LostAndFoundController : Controller
    {


        private readonly ApplicationDbContext _db;

        // GET: DiscussionForum
        public LostAndFoundController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var lostandfound = _db.LostAndFound; 

            if (lostandfound.Any() == false)
            {
                return RedirectToAction(nameof(Create)); 
            }
            return View(lostandfound); 

            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var lostandfound = _db.LostAndFound.Where(m => m.IdentityUserId == userId);
            //if (lostandfound == null)
            //{
            //    return RedirectToAction(nameof(Create));
            //}

            //else
            //{
            //    return View(lostandfound);
            //}
        }
        //GET: DiscussionForum/Details/5
        public ActionResult EmergencyResources()
        {
            return View();
        }

        // GET: DiscussionForum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiscussionForum/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Message,Created")] LostAndFound lostandfound)
        {
            if (ModelState.IsValid)
            {
                //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                //lostandfound.IdentityUserId = userId;
                _db.LostAndFound.Add(lostandfound);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
     
            //ViewData["IdentityUserId"] = new SelectList(_db.Users, "Id", "Id", lostandfound.IdentityUserId);
            return View(lostandfound);
        }

        // GET: DiscussionForum/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DiscussionForum/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DiscussionForum/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DiscussionForum/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}

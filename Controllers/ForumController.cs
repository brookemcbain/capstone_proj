using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Capstone.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace Capstone.Controllers
{
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext _db;

        // GET: DiscussionForum
        public ForumController(ApplicationDbContext db)
        {
            _db = db; 
        }
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var neighbor = _db.Posts.Where(m => m.IdentityUserId == userId);
            if (neighbor == null)
            {
                return RedirectToAction(nameof(Create));
            }

            else
            {
                return View(neighbor);
            }


        }

        // GET: DiscussionForum/Details/5
        public ActionResult Details(int id)
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
        public ActionResult Create(Post post)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                post.IdentityUserId = userId;
                _db.Posts.Add(post);
                _db.SaveChanges(); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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

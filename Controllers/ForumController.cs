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
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var posts = _db.Posts; 
            if(posts.Any() == false)
            {
                return RedirectToAction(nameof(Create)); 
            }
            return View(posts); 
            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var neighbor = _db.Posts.Where(m => m.IdentityUserId == userId);
            //if (neighbor == null)
            //{
            //    return RedirectToAction(nameof(Create));
            //}

            //else
            //{
            //    return View(neighbor);
            //}
        }

        //GET: DiscussionForum/Details/5
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
        public async Task<IActionResult> Create([Bind("Title,Message,Created")] Post post)
        {
            if (ModelState.IsValid)
            {
                //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                //post.IdentityUserId = userId;
                _db.Posts.Add(post);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["IdentityUserId"] = new SelectList(_db.Users, "Id", "Id", post.IdentityUserId);
            return View(post); 
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Replies([Bind("Title,Message")] Post post)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                post.IdentityUserId = userId;
                _db.Posts.Add(post);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_db.Users, "Id", "Id", post.IdentityUserId);
            return View(post);
        }
        public ActionResult EditReplies(int id)
        {
            return View();
        }

        // POST: DiscussionForum/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditReplies(int id, IFormCollection collection)
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New()
        {
            return View(); 
        }

    }
}

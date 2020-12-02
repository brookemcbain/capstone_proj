using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;
using Capstone.Services;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailService _emailServices; 
        public EmailController(IEmailService emailServices )
        {
            this._emailServices = emailServices; 
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendMail(Email email)
        {
            if (!ModelState.IsValid)
            {
                return View(email); 
            }
            await this._emailServices.SendEmail(email);
            return RedirectToAction(nameof(Success)); 
        }
        public IActionResult Success()
        {
            return View(); 
        }
        public ActionResult Details()
        {
            return View(); 
        }
    }
}

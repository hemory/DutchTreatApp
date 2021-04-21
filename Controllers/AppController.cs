using System;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly INullMailService _mailService;

        public AppController(INullMailService mailService)
        {
            _mailService = mailService;
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //send email
                _mailService.SendMessage("hphife@yahoo.com", model.Subject, $"{model.Name} - From: {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();
            }
            
            return View();
        }
        
        public IActionResult About()
        {
            ViewBag.Title = "About Us"; 
            
            return View();
            
        }
    }
}
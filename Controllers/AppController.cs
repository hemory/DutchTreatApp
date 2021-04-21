using System;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
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
            }
            else
            {
                //show the errors
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // this method will display a greeting to the user depending on their time
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string timeOfDay;
            if (hour < 12)
                timeOfDay = "Good Morning";
            else if (hour < 18)
                timeOfDay = "Good Afternoon";
            else
                timeOfDay = "Good Evening";
            ViewBag.Greeting = timeOfDay;
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
              
                return View("Thanks", guestResponse);
            }
            else
            {
               
                return View();
            }
        }
    }
}
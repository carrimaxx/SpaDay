using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //[Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user/")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if(newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return View("index");
            }
            else
            {
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                ViewBag.error = "Your password should match";
                return View("add");
            }
            
             // use model binding to create newUser
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignalR.Models.ORM.Context;
using SignalR.Models.ORM.Entities;

namespace SignalR.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _chatContext;

        public HomeController(Context chatContext)
        {
            _chatContext = chatContext;
        }

        public IActionResult Index()
        {
            ViewBag.username = HttpContext.User.Claims.ToArray()[2].Value;
            ViewBag.loginID = HttpContext.User.Claims.ToArray()[1].Value;
            List<User> users = _chatContext.Users.ToList();

            return View(users);
        }
    }
}

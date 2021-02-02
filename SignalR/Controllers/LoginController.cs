using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SignalR.Models.ORM.Context;
using SignalR.Models.VM;

namespace SignalR.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context _chatContext;


        public LoginController(Context chatContext)
        {
            _chatContext = chatContext;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            var user = _chatContext.Users.FirstOrDefault(x => x.EMail == model.email && x.Password == model.password);

            if (user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, model.email),
                    new Claim(ClaimTypes.Name, user.ID.ToString())

                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return Redirect("/Home/Index");

            }
            else
            {
                ViewBag.error = "You do not exist";
                return View();
            }

        }

    }
}

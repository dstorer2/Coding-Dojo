using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LogReg.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LogReg.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("loggedIn", 0);

            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(user => user.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");

                    return View("Index");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

                _context.Users.Add(newUser);
                _context.SaveChanges();

                HttpContext.Session.SetInt32("loggedIn", 1);

                return RedirectToAction("Success");
            }

            return View("Index");
        }

        [HttpGet("Login")]
        public IActionResult LoginPage()
        {
            return View();
        }
        [HttpPost("checkLogin")]
        public IActionResult CheckLogin(LoginUser login)
        {
            if(ModelState.IsValid)
            {
                var userInDb = _context.Users.FirstOrDefault(user => user.Email == login.LoginEmail);

                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid login");

                    return View("Index");
                }

                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();

                var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LoginPassword);

                if(result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid login");
                    return View("Index");
                }

                Console.WriteLine("Logged in");
                HttpContext.Session.SetInt32("loggedIn", 1);

                return RedirectToAction("Success");
            }
            return View("Index");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("loggedIn") == null || HttpContext.Session.GetInt32("loggedIn") == 0)
            {
                ModelState.AddModelError("Email", "Must be logged in to access this site.");
                return View("Index");
            }

            return View();
        }

        [HttpGet("logoff")]
        public IActionResult Logoff()
        {
            HttpContext.Session.SetInt32("loggedIn", 0);

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

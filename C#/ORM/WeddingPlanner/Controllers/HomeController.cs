using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
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
                User  activeUser= _context.Users.FirstOrDefault(u => u.Email == newUser.Email);
                HttpContext.Session.SetInt32("userId", activeUser.UserId);

                return RedirectToAction("Dashboard");
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

                User  activeUser= _context.Users.FirstOrDefault(u => u.Email == login.LoginEmail);
                HttpContext.Session.SetInt32("userId", activeUser.UserId);

                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int userId = (int)HttpContext.Session.GetInt32("userId");
            int loggedIn = (int)HttpContext.Session.GetInt32("loggedIn");
            if(loggedIn != 1){ModelState.AddModelError("LoginEmail", "Must be logged in to access site"); return View("Index");}

            ViewBag.User = _context.Users
                .FirstOrDefault(u => u.UserId == userId);
            
            ViewBag.AllWeddings = _context.Weddings
                .Include(w => w.Attendees)
                    .ThenInclude(a => a.User)
                .Include(w => w.Creator)
                .ToList();

            return View();
        }
        [HttpGet("wedding/{id}")]
        public IActionResult ViewWedding(int id)
        {
            int loggedIn = (int)HttpContext.Session.GetInt32("loggedIn");
            if(loggedIn != 1){ModelState.AddModelError("LoginEmail", "Must be logged in to access site"); return View("Index");}

            ViewBag.OneWedding = _context.Weddings
                .Include(w => w.Attendees)
                    .ThenInclude(a => a.User)
                .FirstOrDefault(w => w.WeddingId == id);

            return View();
        }
        [HttpGet("attendance/{id}/submit")]
        public IActionResult SubmitRSVP(int id)
        {
            Attendance newAttend = new Attendance
            {
                WeddingId = id,
                UserId = (int)HttpContext.Session.GetInt32("userId")
            };

            _context.Add(newAttend);
            _context.SaveChanges();

            return RedirectToAction("Dashboard");

        }

        [HttpGet("attendance/{id}/delete")]
        public IActionResult DeleteRSVP(int id)
        {
            Attendance deleteMe = _context.Attendances
                .FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("userId") && a.WeddingId == id);

            _context.Remove(deleteMe);
            _context.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpGet("wedding/add")]
        public IActionResult NewWedding()
        {
            int loggedIn = (int)HttpContext.Session.GetInt32("loggedIn");
            if(loggedIn != 1){ModelState.AddModelError("LoginEmail", "Must be logged in to access site"); return View("Index");}

            ViewBag.userId = (int)HttpContext.Session.GetInt32("userId");

            return View();
        }

        [HttpPost("wedding/submit")]
        public IActionResult SubmitWedding(Wedding newWed)
        {
            _context.Add(newWed);
            _context.SaveChanges();
            return RedirectToAction("dashboard");
        }

        [HttpGet("wedding/{id}/delete")]
        public IActionResult DeleteWedding(int id)
        {
            Wedding deleteMe = _context.Weddings.FirstOrDefault(w => w.WeddingId == id);

            _context.Weddings.Remove(deleteMe);
            _context.SaveChanges();

            return RedirectToAction("Dashboard");
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

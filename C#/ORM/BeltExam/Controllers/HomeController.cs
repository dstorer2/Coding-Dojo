using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeltExam.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace BeltExam.Controllers
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
            if(HttpContext.Session.GetInt32("loggedIn") == null){return RedirectToAction("Index");}
            int loggedIn = (int)HttpContext.Session.GetInt32("loggedIn");
            if(HttpContext.Session.GetInt32("loggedIn") == 0){ModelState.AddModelError("LoginEmail", "Must be logged in to access site"); return View("Index");}

            int userId = (int)HttpContext.Session.GetInt32("userId");
            ViewBag.User = _context.Users.FirstOrDefault(u => u.UserId == userId);
            
            ViewBag.AllGatherings = _context.Gatherings
                .Include(w => w.Attendees)
                    .ThenInclude(a => a.User)
                .Include(w => w.Creator)
                .OrderBy(gat => gat.Date)
                .ToList();

            return View();
        }

        [HttpGet("gathering/add")]
        public IActionResult NewGathering()
        {
            if(HttpContext.Session.GetInt32("loggedIn") == null){return RedirectToAction("Index");}
            int loggedIn = (int)HttpContext.Session.GetInt32("loggedIn");
            if(HttpContext.Session.GetInt32("loggedIn") == 0){ModelState.AddModelError("LoginEmail", "Must be logged in to access site"); return View("Index");}

            int userId = (int)HttpContext.Session.GetInt32("userId");
            ViewBag.User = _context.Users.FirstOrDefault(u => u.UserId == userId);

            return View();
        }

        [HttpPost("gathering/submit")]
        public IActionResult SubmitGathering(Gathering newGat)
        {
            int userId = (int)HttpContext.Session.GetInt32("userId");
            ViewBag.User = _context.Users.FirstOrDefault(u => u.UserId == userId);

            if(newGat.Date < DateTime.Now)
            {
                ModelState.AddModelError("Date", "Event must take place in the future");

                return View("NewGathering");
            }

            if(ModelState.IsValid)
            {
                _context.Add(newGat);
                _context.SaveChanges();

                Gathering createdGat = _context.Gatherings
                    .Include(g => g.Attendees)
                        .ThenInclude(a => a.User)
                    .FirstOrDefault(g => g.Title == newGat.Title && g.UserId == userId);

                return RedirectToAction("ViewGathering", new {id = createdGat.GatheringId});
            }

            return View("NewGathering");
        }

        [HttpGet("gathering/{id}")]
        public IActionResult ViewGathering(int id)
        {
            if(HttpContext.Session.GetInt32("loggedIn") == null){return RedirectToAction("Index");}
            int loggedIn = (int)HttpContext.Session.GetInt32("loggedIn");
            if(HttpContext.Session.GetInt32("loggedIn") == 0){ModelState.AddModelError("LoginEmail", "Must be logged in to access site"); return View("Index");}

            int userId = (int)HttpContext.Session.GetInt32("userId");
            ViewBag.User = _context.Users.FirstOrDefault(u => u.UserId == userId);

            ViewBag.OneGathering = _context.Gatherings
                .Include(gat => gat.Creator)
                .Include(gat => gat.Attendees)
                    .ThenInclude(att => att.User)
                .FirstOrDefault(gat => gat.GatheringId == id);

            return View();
        }

        [HttpGet("attendance/{id}/submit")]
        public IActionResult SubmitAttendance(int id)
        {
            int UserId = (int)HttpContext.Session.GetInt32("userId");

            Attendance newAttend = new Attendance
            {
                GatheringId = id,
                UserId = UserId
            };

            _context.Add(newAttend);
            _context.SaveChanges();

            return RedirectToAction("Dashboard");
        }

        [HttpGet("attendance/{id}/delete")]
        public IActionResult DeleteAttendance(int id)
        {
            int UserId = (int)HttpContext.Session.GetInt32("userId");

            Attendance deleteMe = _context.Attendances
                .FirstOrDefault(att => att.UserId == UserId && att.GatheringId == id);

            if(deleteMe.UserId == UserId)
            {
                _context.Remove(deleteMe);
                _context.SaveChanges();

                return RedirectToAction("Dashboard");
            }

            return RedirectToAction("Dashboard");
        }

        [HttpGet("gathering/{id}/delete")]
        public IActionResult DeleteGathering(int id)
        {
            Gathering deleteMe = _context.Gatherings
                .FirstOrDefault(gat => gat.GatheringId == id);

            int UserId = (int)HttpContext.Session.GetInt32("userId");

            if(deleteMe.UserId == UserId)
            {
                _context.Remove(deleteMe);
                _context.SaveChanges();

                return RedirectToAction("Dashboard");
            }

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

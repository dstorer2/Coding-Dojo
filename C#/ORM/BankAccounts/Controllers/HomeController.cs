using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BankAccounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Controllers
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

                User createdUser = _context.Users
                    .FirstOrDefault(user => user.Email == newUser.Email);

                HttpContext.Session.SetInt32("userId", createdUser.UserId);

                HttpContext.Session.SetInt32("loggedIn", 1);

                return RedirectToAction("Profile");
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
                HttpContext.Session.SetInt32("userId", userInDb.UserId);

                return RedirectToAction("Profile");
            }
            return View("Index");
        }

        [HttpGet("dashboard")]
        public IActionResult Profile()
        {
            int ID = (int)HttpContext.Session.GetInt32("userId");
            ViewBag.ActiveUser = _context.Users
                .Include(user => user.CreatedAccounts)
                .FirstOrDefault(user => user.UserId == ID);

            Console.WriteLine(ViewBag.ActiveUser);
            return View();
        }
        [HttpGet("accounts/add")]
        public IActionResult AddAccount()
        {
            ViewBag.userId = HttpContext.Session.GetInt32("userId");
            return View();
        }

        [HttpPost("accounts/submit")]
        public IActionResult SubmitAccount(Account newAcct)
        {
            if(ModelState.IsValid){

                _context.Accounts.Add(newAcct);
                _context.SaveChanges();

                return RedirectToAction("Profile");
            }

            return View("accounts/add");
        }

        [HttpGet("accounts/{id}")]
        public IActionResult ViewAccount(int id)
        {
            ViewBag.Acct = _context.Accounts
                .Include(a => a.Owner)
                .Include(tran => tran.CompletedTransactions)
                .FirstOrDefault(a => a.AcctId == id);

            ViewBag.Trans = _context.Transactions
                .Where(acct => acct.AcctId == id)
                .ToList();

            return View();
        }

        [HttpPost("transactions/submit")]
        public IActionResult SubmitTransaction(Transaction newTrans)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newTrans);
                int amt = newTrans.Amount;
                Account acct = _context.Accounts.FirstOrDefault(acnt => acnt.AcctId == newTrans.AcctId);
                acct.Balance += amt;
                acct.UpdatedAt = DateTime.Now;
                _context.SaveChanges();

                return RedirectToAction("ViewAccount", new {id = newTrans.AcctId});
            }

            return View("ViewAccount");
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

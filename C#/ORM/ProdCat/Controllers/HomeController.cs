using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProdCat.Models;
using Microsoft.EntityFrameworkCore;

namespace ProdCat.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllProd = _context.Products.ToList();
            return View();
        }

        [HttpGet("categories")]
        public IActionResult AllCategories()
        {
            ViewBag.AllCat = _context.Categories.ToList();
            return View();
        }
        [HttpPost("products/submit")]
        public IActionResult SubmitProduct(Product newProd)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newProd);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Index");
        }

        [HttpPost("categories/submit")]
        public IActionResult SubmitCategory(Category newCat)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newCat);
                _context.SaveChanges();

                return RedirectToAction("AllCategories");
            }
            return View("AllCategories");
        }
        [HttpGet("products/{id}")]
        public IActionResult ViewProduct(int id)
        {
            ViewBag.OneProd = _context.Products
                .Include(prod => prod.AllCategories)
                    .ThenInclude(assoc => assoc.Category)
                .FirstOrDefault(prod => prod.ProductId == id);
            
            ViewBag.AllCat = _context.Categories
                .Include(c => c.AllProducts)
                .Where(p => p.AllProducts.All(a => a.ProductId != id))
                .ToList();
            
            return View();
        }

        [HttpPost("products/addAssociation")]
        public IActionResult SubmitProductAssociation(Association newAssoc)
        {
            _context.Add(newAssoc);
            _context.SaveChanges();
            return RedirectToAction("ViewProduct", new {id = newAssoc.ProductId});
        }

        [HttpGet("categories/{id}")]
        public IActionResult ViewCategory(int id)
        {
            ViewBag.OneCat = _context.Categories
                .Include(cat => cat.AllProducts)
                    .ThenInclude(assoc => assoc.Product)
                .FirstOrDefault(cat => cat.CategoryId == id);
            
            ViewBag.AllProd = _context.Products
                .Include(p => p.AllCategories)
                .Where(c => c.AllCategories.All(a => a.CategoryId != id))
                .ToList();

            return View();
        }

        [HttpPost("categories/addAssociation")]
        public IActionResult SubmitCategoryAssociation(Association newAssoc)
        {
            _context.Add(newAssoc);
            _context.SaveChanges();
            return RedirectToAction("ViewCategory", new {id = newAssoc.CategoryId});
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lighten.Data;
using Lighten.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lighten.Controllers
{
    public class ProductController : Controller
    {
        private readonly LightenContext _context;

        public ProductController(LightenContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
          return View(await _context.Products.ToListAsync());
        }
        public async Task<IActionResult> AddItem(int? id)
        {
            if (HttpContext.Session.GetString("Id") != null)
            {
                var value = HttpContext.Session.GetString("Id");

                YourProducts buyBook = new YourProducts();
                var book = _context.Products.Where(x => x.Id == id).FirstOrDefault();
                buyBook.LightModel = book.LightModel;
                buyBook.LightCompany = book.LightCompany;
                buyBook.LightType = book.LightType;
                buyBook.Price = book.Price;
                buyBook.UserId = Convert.ToInt32(value);
                _context.Add(buyBook);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "YourProducts");
            }
            else
                return RedirectToAction("UserAuthenticate", "Authenticate");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternetShop.Models;

namespace InternetShop.Controllers
{
    public class CategoriesController : Controller
    {
        ShopContext db;

        public CategoriesController(ShopContext context)
        {
            db = context;
        }

        [Route("")]
        [Route("categories")]
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        [Route("{itemsName}")]
        public IActionResult Items(string itemsName)
        {
            var items = db.Items.Where(i => i.Category == itemsName).ToList();
            ViewBag.NameCategory = itemsName;
            if (items.Count != 0)
                return View("Items", items);
            else return NotFound();
        }
    }
}
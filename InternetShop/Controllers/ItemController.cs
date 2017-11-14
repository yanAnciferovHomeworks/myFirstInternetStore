using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InternetShop.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.Controllers
{
    public class ItemController : Controller
    {

        ShopContext db;

        public ItemController(ShopContext context)
        {
            db = context;
        }

        [Route("item/{id:int}")]
        public IActionResult Index(int id)
        {
            try
            {
                    
                Item item = db.Items
                    .Include(i=>i.Comments)
                    .Include(p=>p.Properties)
                    .Where(i => i.Id == id).First();
            
                return View("ItemDetail", item);

            }
            catch (Exception)
            {
                return NotFound();
               
            }           
        }

        [HttpPost]
        public IActionResult AddComment(int id,string name, string text)
        {
            Item item = db.Items
                    .Include(i => i.Comments)
                    .Where(i => i.Id == id).First();
            item.Comments.Add(new Comment() { Date = new DateTime().ToLocalTime(), Text = text, UserName = name});
            db.SaveChanges();
            return View("ItemDetail", item);
        }

        [HttpPost]
        public IActionResult Buy(Purchase purchase)
        {

            db.Purchases.Add(purchase);
            Item item = db.Items.Where(i => i.Id == purchase.ItemId).First();
            item.Count--;
            db.SaveChanges();
            ViewBag.Name = purchase.Name;
            return View("PostBuy");
        } 

        [HttpGet]
        public IActionResult Buy(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }

        [Route("allitems")]
        public IActionResult AllItems()
        {
            return View("AllItems",db.Items.ToList());
        }
    }
}
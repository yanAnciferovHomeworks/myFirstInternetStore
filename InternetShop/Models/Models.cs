using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetShop.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public int ItemId { get; set; }
    }

    public class Property
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public DateTime IsPrimary { get; set; }
    }

    public class Purchase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Addres { get; set; }
        public int ItemId { get; set; }
    }

    public class Item
    {
        public Item()
        {
            Comments = new List<Comment>();
            Properties = new List<Property>();
        }
        public string Category { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Property> Properties { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ItemName { get; set; }
        public string Img { get; set; }
    }

    public class ShopContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

    }

   
}

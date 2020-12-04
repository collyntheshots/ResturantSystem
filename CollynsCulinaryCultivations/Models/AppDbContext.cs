using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class AppDbContext: IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Appetizers" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Entrees" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Desserts" });

            //seed pies

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Cheese Sticks",
                Price = 5.95M,
                ShortDescription = "Our amazing Cheese Sticks!",
                LongDescription = "Default text",
                CategoryId = 1,
                ImageUrl = "https://localhost:44351/Images/Cheesesticks.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://localhost:44351/Images/Cheesesticks.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name = "Tacos",
                Price = 10.95M,
                ShortDescription = "You'll love it!",
                LongDescription = "Default text",
                CategoryId = 2,
                ImageUrl = "https://localhost:44351/Images/Taco.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44351/Images/Taco.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 3,
                Name = "Hamburger",
                Price = 18.95M,
                ShortDescription = "What's better than a Hamburger!",
                LongDescription = "Default text",
                CategoryId = 2,
                ImageUrl = "https://localhost:44351/Images/Hamburger.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44351/Images/Hamburger.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 4,
                Name = "Korean Meat on a Stick",
                Price = 15.95M,
                ShortDescription = "The best Korean Meat on a stick that you can get in the US",
                LongDescription = "Default text",
                CategoryId = 1,
                ImageUrl = "https://localhost:44351/Images/Kormeatonstick.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44351/Images/Kormeatonstick.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 5,
                Name = "Christmas Apple Pie",
                Price = 13.95M,
                ShortDescription = "Happy holidays with this pie!",
                LongDescription = "Default text",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 6,
                Name = "Cranberry Pie",
                Price = 17.95M,
                ShortDescription = "A Christmas favorite",
                LongDescription = "Default text",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 7,
                Name = "Meat pies",
                Price = 15.95M,
                ShortDescription = "Nigerian Meat pies",
                LongDescription = "Default text",
                CategoryId = 1,
                ImageUrl = "https://localhost:44351/Images/Meatpie.jpg",
                InStock = false,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44351/Images/Meatpie.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 8,
                Name = "Pumpkin Pie",
                Price = 12.95M,
                ShortDescription = "Our Halloween favorite",
                LongDescription = "Default text",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 9,
                Name = "Nachos",
                Price = 15.95M,
                ShortDescription = "Nachos, does anything more have to be said",
                LongDescription = "Default text",
                CategoryId = 1,
                ImageUrl = "https://localhost:44351/Images/Nachos.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbnailUrl = "https://localhost:44351/Images/Nachos.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 10,
                Name = "Sliders",
                Price = 15.95M,
                ShortDescription = "Turkey Sliders",
                LongDescription = "Default text",
                CategoryId = 1,
                ImageUrl = "https://localhost:44351/Images/Sliders.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44351/Images/Sliders.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 11,
                Name = "Hot dog",
                Price = 18.95M,
                ShortDescription = "Can never go wrong with a good american dog",
                LongDescription = "Default text",
                CategoryId = 2,
                ImageUrl = "https://localhost:44351/Images/Hotdog.jpg",
                InStock = false,
                IsPieOfTheWeek = false,
                ImageThumbnailUrl = "https://localhost:44351/Images/Hotdog.jpg",
                AllergyInformation = ""
            });
        }
    }
}

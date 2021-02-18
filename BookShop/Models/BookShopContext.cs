﻿using BookShop.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShop.Models;
using BookShop.Models.ViewModels;
using BookShop.Areas.Identity.Data;
using BookShop.Areas.Admin.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BookShop.Models
{
    public class BookShopContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, ApplicationRoleClaim, IdentityUserToken<string>>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=BookShopDB;Trusted_Connection=True");
            //optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=(local);Database=BookShopDB;Trusted_Connection=True");
            

            
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);   //IdentityDBContext

            modelBuilder.ApplyConfiguration(new Author_BookMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new Order_BookMap());
            modelBuilder.ApplyConfiguration(new Book_TranslatorMap());
            modelBuilder.ApplyConfiguration(new Book_CategoryMap());
            modelBuilder.Query<ReadAllBooks>().ToView("ReadAllBooks");
            // modelBuilder.Entity<Book>().HasQueryFilter(b => (bool)!b.Delete);
            modelBuilder.Entity<Book>().Property(b => b.Delete).HasDefaultValueSql("0");
            modelBuilder.Entity<Book>().Property(b => b.PublishDate).HasDefaultValueSql("convert(datetime,GETDATE())");  //method for insert default field with sqlquery

            ///////////////////////////IdentityDBContext///////////////////////////////////////////////////
          
            modelBuilder.Entity<ApplicationRole>().ToTable("AspNetRoles").ToTable("AppRoles");

            modelBuilder.Entity<ApplicationUserRole>().ToTable("AppUserRole");   //change Table Name


            modelBuilder.Entity<ApplicationUserRole>()   // one to many
                .HasOne(userRole => userRole.Role)
                .WithMany(role => role.Users).HasForeignKey(r => r.RoleId);


            modelBuilder.Entity<ApplicationUser>().ToTable("AppUsers");

            modelBuilder.Entity<ApplicationUserRole>()   // one to many
               .HasOne(userRole => userRole.User)    //NavigationProperty User ( userRole.User)
               .WithMany(role => role.Roles).HasForeignKey(r => r.UserId);  //NavigationProperty Roles ( role.Roles) and foregnKey(UserId)


            modelBuilder.Entity<ApplicationRoleClaim>().ToTable("AppRoleClaim");
            modelBuilder.Entity<ApplicationRoleClaim>()
                .HasOne(roleclaim => roleclaim.Role)
                .WithMany(claim => claim.Claims).HasForeignKey(c => c.RoleId);

        }

        public DbSet<Book> Books { get; set; }
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Provice> Provices { get; set; }
        public DbSet<Author_Book> Author_Books { get; set; }
        public DbSet<Order_Book> Order_Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Translator> Translator { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book_Category> Book_Categories { get; set; }
        public DbSet<Book_Translator> Book_Translators { get; set; }
        public  DbQuery<ReadAllBooks> ReadAllBooks { get; set; }


        [DbFunction("GetAllAuthor","dbo")]
        public static string GetAllAuthors(int BookID)
        {
            throw new NotImplementedException();

        }


        [DbFunction("GetAllTranslators", "dbo")]
        public static string GetAllTranslators(int BookID)
        {
            throw new NotImplementedException();

        }

        [DbFunction("GetAllCategories", "dbo")]
        public static string GetAllCategories(int BookID)
        {
            throw new NotImplementedException();

        }
    }
}

namespace BooksDAL.Migrations
{
    using BooksDAL.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BooksDAL.EF.BooksEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BooksDAL.EF.BooksEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var users = new List<User>
            {
                new User {FirstName="Adam", LastName="Nowak"},
                new User {FirstName="Alicja", LastName="Zając"},
                new User {FirstName="Bartosz", LastName="Palit"},
                new User {FirstName="Zenon", LastName="Karaś"},
                new User {FirstName="Katarzyna", LastName="Kowalska"}
            };
            users.ForEach(x => context.Users.AddOrUpdate(u=> new { u.FirstName, u.LastName},x));

            var categories = new List<Category>
            {
                new Category {CategoryId=1,CategoryName="Karty", CategoryDescription="Karty oraz przewodniki ezoteryczne."},
                new Category {CategoryId=2,CategoryName="E-booki", CategoryDescription="Karty oraz przewodniki ezoteryczne zawarte w E-bookach."}
            };
            categories.ForEach(x => context.Categories.AddOrUpdate(c=> new { c.CategoryId, c.CategoryName, c.CategoryDescription},x));

            var products = new List<Product>
            {
                new Product {ProductTitle="Tarot zwierciadło duszy", CategoryId=1, ProductAuthor="Gerd Ziegler", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=111,ISBN="978-80-7370-191-8"},
                new Product {ProductTitle="Mistrzowie Duchowi", CategoryId=1, ProductAuthor="Dr Doreen Virtue", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=79,ISBN="978-80-7370-047-8"},
                new Product {ProductTitle="Tarot Thota", CategoryId=1, ProductAuthor="ALEISTER CROWLEY", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=62,ISBN="978-80-7370-179-6"},
                new Product {ProductTitle="Cud jednorożców", CategoryId=1, ProductAuthor="COOPER DIANA", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=122,ISBN="978-80-7370-151-2"},
                new Product {ProductTitle="Mistyczny Tarot Marzyciela", CategoryId=1, ProductAuthor="HEIDI DARRAS, BARBARA MOORE", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=98,ISBN="978-80-7370-183-3"}
            };
            products.ForEach(x => context.Products.AddOrUpdate(p=> new { p.ProductTitle, p.CategoryId, p.ProductAuthor, p.ProductDescription, p.ProductShortDescription, p.AddedDate, p.ProductPrice, p.ISBN}));
        }
    }
}

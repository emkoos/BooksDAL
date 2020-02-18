using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksDAL.Models;
using System.Data.Entity;

namespace BooksDAL.EF
{
    public class DataInitializer : DropCreateDatabaseAlways<BooksEntities>
    {
        protected override void Seed(BooksEntities context)
        {
            var users = new List<User>
            {
                new User {FirstName="Adam", LastName="Nowak"},
                new User {FirstName="Alicja", LastName="Zając"},
                new User {FirstName="Bartosz", LastName="Palit"},
                new User {FirstName="Zenon", LastName="Karaś"},
                new User {FirstName="Katarzyna", LastName="Kowalska"}
            };
            users.ForEach(x => context.Users.Add(x));

            var categories = new List<Category>
            {
                new Category {CategoryName="Karty", CategoryDescription="Karty oraz przewodniki ezoteryczne."},
                new Category {CategoryName="E-booki", CategoryDescription="Karty oraz przewodniki ezoteryczne zawarte w E-bookach."}
            };
            categories.ForEach(x => context.Categories.Add(x));

            var products = new List<Product>
            {
                new Product {ProductTitle="Tarot zwierciadło duszy", ProductAuthor="Gerd Ziegler", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=111,ISBN="978-80-7370-191-8"},
                new Product {ProductTitle="Mistrzowie Duchowi", ProductAuthor="Dr Doreen Virtue", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=79,ISBN="978-80-7370-047-8"},
                new Product {ProductTitle="Tarot Thota", ProductAuthor="ALEISTER CROWLEY", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=62,ISBN="978-80-7370-179-6"},
                new Product {ProductTitle="Cud jednorożców", ProductAuthor="COOPER DIANA", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=122,ISBN="978-80-7370-151-2"},
                new Product {ProductTitle="Mistyczny Tarot Marzyciela", ProductAuthor="HEIDI DARRAS, BARBARA MOORE", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=98,ISBN="978-80-7370-183-3"}
            };
            products.ForEach(x => context.Products.Add(x));

            context.SaveChanges();
        }
    }
}

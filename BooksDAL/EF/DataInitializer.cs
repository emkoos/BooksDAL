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
                new Category {CategoryId=1,CategoryName="Powieści", CategoryDescription="Powieści z łatwością odbierzesz najlepiej wieczorami."},
                new Category {CategoryId=2,CategoryName="Kryminały", CategoryDescription="Kryminały to najlepsze pozycje na piątkowy wieczór."},
                new Category {CategoryId=3,CategoryName="Dla dzieci", CategoryDescription="Pozycje dla twojego dziecka."},

            };
            categories.ForEach(x => context.Categories.Add(x));

            var products = new List<Product>
            {
                new Product {ProductTitle="Produkt 1", CategoryId=1, ProductAuthor="Autor 1", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=111,ISBN="932-50-7360-423-4"},
                new Product {ProductTitle="Produkt 2", CategoryId=3, ProductAuthor="Autor 2", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=79,ISBN="948-32-3560-363-7"},
                new Product {ProductTitle="Produkt 3", CategoryId=2, ProductAuthor="Autor 3", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=62,ISBN="832-30-3360-553-3"},
                new Product {ProductTitle="Produkt 4", CategoryId=1, ProductAuthor="Autor 4", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=122,ISBN="902-54-7356-433-8"},
                new Product {ProductTitle="Produkt 5", CategoryId=2, ProductAuthor="Autor 5", ProductDescription="Opis", ProductShortDescription="Krótki opis", AddedDate=DateTime.Now, ProductPrice=98,ISBN="976-64-7655-654-1"}
            };
            products.ForEach(x => context.Products.Add(x));

            context.SaveChanges();
        }
    }
}

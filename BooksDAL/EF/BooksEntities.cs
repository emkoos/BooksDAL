namespace BooksDAL.EF
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using BooksDAL.Models;

    public class BooksEntities : DbContext
    {
        // Your context has been configured to use a 'BooksEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BooksDAL.EF.BooksEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BooksEntities' 
        // connection string in the application configuration file.
        public BooksEntities()
            : base("name=BooksConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<OrderPosition> OrderPosition { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CartPosition> CartPosition { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
namespace BooksDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product_Info_Field : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Info", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Info");
        }
    }
}

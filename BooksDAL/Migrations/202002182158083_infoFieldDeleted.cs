﻿namespace BooksDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class infoFieldDeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Info");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Info", c => c.String());
        }
    }
}

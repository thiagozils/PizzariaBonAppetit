namespace PizzariaBonAppetit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "Employee_Id" });
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Prize = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "Size_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Size_Id");
            AddForeignKey("dbo.Orders", "Size_Id", "dbo.Sizes", "Id");
            DropColumn("dbo.Orders", "Employee_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Employee_Id", c => c.Int());
            DropForeignKey("dbo.Orders", "Size_Id", "dbo.Sizes");
            DropIndex("dbo.Orders", new[] { "Size_Id" });
            DropColumn("dbo.Orders", "Size_Id");
            DropTable("dbo.Sizes");
            CreateIndex("dbo.Orders", "Employee_Id");
            AddForeignKey("dbo.Orders", "Employee_Id", "dbo.Employees", "Id");
        }
    }
}

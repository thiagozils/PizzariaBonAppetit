namespace PizzariaBonAppetit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Orders", "Pizza_Id", "dbo.Pizzas");
            DropForeignKey("dbo.Orders", "Size_Id", "dbo.Sizes");
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropIndex("dbo.Orders", new[] { "Pizza_Id" });
            DropIndex("dbo.Orders", new[] { "Size_Id" });
            RenameColumn(table: "dbo.Orders", name: "Customer_Id", newName: "CustomerId");
            RenameColumn(table: "dbo.Orders", name: "Pizza_Id", newName: "PizzaId");
            RenameColumn(table: "dbo.Orders", name: "Size_Id", newName: "SizeId");
            AlterColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "PizzaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "SizeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "PizzaId");
            CreateIndex("dbo.Orders", "CustomerId");
            CreateIndex("dbo.Orders", "SizeId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "PizzaId", "dbo.Pizzas", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "SizeId", "dbo.Sizes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.Orders", "PizzaId", "dbo.Pizzas");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "SizeId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Orders", new[] { "PizzaId" });
            AlterColumn("dbo.Orders", "SizeId", c => c.Int());
            AlterColumn("dbo.Orders", "PizzaId", c => c.Int());
            AlterColumn("dbo.Orders", "CustomerId", c => c.Int());
            RenameColumn(table: "dbo.Orders", name: "SizeId", newName: "Size_Id");
            RenameColumn(table: "dbo.Orders", name: "PizzaId", newName: "Pizza_Id");
            RenameColumn(table: "dbo.Orders", name: "CustomerId", newName: "Customer_Id");
            CreateIndex("dbo.Orders", "Size_Id");
            CreateIndex("dbo.Orders", "Pizza_Id");
            CreateIndex("dbo.Orders", "Customer_Id");
            AddForeignKey("dbo.Orders", "Size_Id", "dbo.Sizes", "Id");
            AddForeignKey("dbo.Orders", "Pizza_Id", "dbo.Pizzas", "Id");
            AddForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}

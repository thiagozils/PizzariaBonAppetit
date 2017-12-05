namespace PizzariaBonAppetit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Cpf", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Orders", "Description", c => c.String(maxLength: 300));
            AlterColumn("dbo.Pizzas", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Pizzas", "Description", c => c.String(maxLength: 300));
            AlterColumn("dbo.Sizes", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sizes", "Name", c => c.String());
            AlterColumn("dbo.Pizzas", "Description", c => c.String());
            AlterColumn("dbo.Pizzas", "Name", c => c.String());
            AlterColumn("dbo.Orders", "Description", c => c.String());
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Employees", "Cpf", c => c.String());
        }
    }
}

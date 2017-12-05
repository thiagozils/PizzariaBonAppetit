namespace PizzariaBonAppetit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pizzas", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pizzas", "Description", c => c.Boolean(nullable: false));
        }
    }
}

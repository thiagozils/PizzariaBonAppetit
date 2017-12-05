namespace PizzariaBonAppetit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Cpf", c => c.String(nullable: false, maxLength: 14));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Cpf", c => c.String());
        }
    }
}

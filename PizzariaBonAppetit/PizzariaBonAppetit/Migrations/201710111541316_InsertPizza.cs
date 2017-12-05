namespace PizzariaBonAppetit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertPizza : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO PIZZAS VALUES ('4QUEIJOS',29.90,'NULO')");
            Sql("INSERT INTO PIZZAS VALUES ('BRÓCOLIS',20.97,'NULO')");
            Sql("INSERT INTO PIZZAS VALUES ('PORTUGUESA',35.87,'NULO')");
            Sql("INSERT INTO PIZZAS VALUES ('CALABRESA',19.90,'NULO')");
            Sql("INSERT INTO PIZZAS VALUES ('FRANGO',18.79,'NULO')");


        }
        
        public override void Down()
        {
        }
    }
}

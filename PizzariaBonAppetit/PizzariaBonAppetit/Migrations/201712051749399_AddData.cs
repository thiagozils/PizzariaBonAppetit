namespace PizzariaBonAppetit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            Sql(@"

                SET IDENTITY_INSERT [dbo].[Pizzas] ON
                INSERT INTO [dbo].[Pizzas] ([Id], [Name], [Prize], [Description]) VALUES (9, N'Bacon', 35.96, N'Mussarela, tomate, bacon em cubos, orégano e azeitonas')
                INSERT INTO [dbo].[Pizzas] ([Id], [Name], [Prize], [Description]) VALUES (10, N'Brócolis', 15.98, N'Mussarela, brócolis, catupiry, orégano e azeitonas')
                INSERT INTO [dbo].[Pizzas] ([Id], [Name], [Prize], [Description]) VALUES (11, N'Camarão Especial', 25.89, N'Mussarela, molho de camarão com palmito picado, orégano e azeitonas')
                INSERT INTO [dbo].[Pizzas] ([Id], [Name], [Prize], [Description]) VALUES (12, N'Cawabunga', 12.56, N'Mussarela, palmito picado, presunto, tomate, cebola, orégano e azeitonas')
                INSERT INTO [dbo].[Pizzas] ([Id], [Name], [Prize], [Description]) VALUES (13, N'Dogão', 33.65, N'Mussarela, salsicha fatiada, molho de tomate, batata palha, orégano e azeitonas')
                INSERT INTO [dbo].[Pizzas] ([Id], [Name], [Prize], [Description]) VALUES (14, N'Estrogonofe Carne', 25.69, N'Mussarela, estrogonofe de carne com champignon, batata palha, orégano e azeitonas')
                SET IDENTITY_INSERT [dbo].[Pizzas] OFF


                SET IDENTITY_INSERT [dbo].[Customers] ON
                INSERT INTO [dbo].[Customers] ([Id], [Cpf], [Name], [Address]) VALUES (6, N'125.125.125-11', N'Isabelle Minell', N'Jaraguá do Sul')
                INSERT INTO [dbo].[Customers] ([Id], [Cpf], [Name], [Address]) VALUES (7, N'369.852.456-98', N'Camila Maas', N'Pomerode')
                INSERT INTO [dbo].[Customers] ([Id], [Cpf], [Name], [Address]) VALUES (8, N'753.369.852-14', N'Julia Nascimento', N'Vila Nova, Jaraguá do Sul')
                INSERT INTO [dbo].[Customers] ([Id], [Cpf], [Name], [Address]) VALUES (9, N'456.987.252-69', N'Jacson Pessoa', N'Guaramirim')
                SET IDENTITY_INSERT [dbo].[Customers] OFF

                SET IDENTITY_INSERT [dbo].[Employees] ON
                INSERT INTO [dbo].[Employees] ([Id], [Cpf], [Name], [Salary]) VALUES (4, N'095.095.095-56', N'Luis Vieira', 1258.69)
                INSERT INTO [dbo].[Employees] ([Id], [Cpf], [Name], [Salary]) VALUES (5, N'584.651.515-45', N'Thiago Andrey Zils', 2598.65)
                INSERT INTO [dbo].[Employees] ([Id], [Cpf], [Name], [Salary]) VALUES (7, N'12.589.658-74', N'Rodrigo', 10000)
                SET IDENTITY_INSERT [dbo].[Employees] OFF


                SET IDENTITY_INSERT [dbo].[Sizes] ON
                INSERT INTO [dbo].[Sizes] ([Id], [Name], [Prize]) VALUES (3, N'Pequena', 12)
                INSERT INTO [dbo].[Sizes] ([Id], [Name], [Prize]) VALUES (4, N'Média', 18)
                INSERT INTO [dbo].[Sizes] ([Id], [Name], [Prize]) VALUES (5, N'Grande', 25)
                INSERT INTO [dbo].[Sizes] ([Id], [Name], [Prize]) VALUES (6, N'Gigante', 30)
                SET IDENTITY_INSERT [dbo].[Sizes] OFF


                SET IDENTITY_INSERT [dbo].[Orders] ON
                INSERT INTO [dbo].[Orders] ([Id], [Description], [CustomerId], [PizzaId], [SizeId], [IsDone]) VALUES (3, N'+Coca Cola 2L', 6, 9, 3, 0)
                INSERT INTO [dbo].[Orders] ([Id], [Description], [CustomerId], [PizzaId], [SizeId], [IsDone]) VALUES (4, N'Borda Catupiry', 7, 11, 3, 0)
                INSERT INTO [dbo].[Orders] ([Id], [Description], [CustomerId], [PizzaId], [SizeId], [IsDone]) VALUES (5, NULL, 9, 13, 5, 1)
                SET IDENTITY_INSERT [dbo].[Orders] OFF

            ");



        }
        
        public override void Down()
        {
        }
    }
}

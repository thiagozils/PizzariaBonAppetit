namespace PizzariaBonAppetit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'36d3f3d1-64be-4f8d-8ecd-6d9efc68d650', N'admin@admin.com', 0, N'ANEopHTCaxKeOHxH0Z8/YkUdYgeUsV5VDocAOrtJslYuXpTc1E31HVsPwvRV7YtDOA==', N'7f3a2be0-cda6-4b5a-9dba-8e9e3b9ec888', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7f6c9c02-00cd-4817-a919-c1a90d4bab94', N'CanManageCustomers')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'36d3f3d1-64be-4f8d-8ecd-6d9efc68d650', N'7f6c9c02-00cd-4817-a919-c1a90d4bab94')
            ");


        }
        
        public override void Down()
        {
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2876b4f9-38b7-4fa2-91c9-8647afc61f16', N'admin@vivdly.com', 0, N'AGhgd3XEzWjXzyh2g9h/kpEQbdd2KvGlRVGgIHfcxNY/48xTlEgZWIMoVRAkYYqXbg==', N'6c93b286-2269-4852-bebf-a0232be89005', NULL, 0, 0, NULL, 1, 0, N'admin@vivdly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9dbc23de-d12d-4074-8f6c-44ab99d66110', N'guest@gmail.com', 0, N'AJBM+VGitUnfAJb9/8SGeXZSYeSonNMaTfq1KilxiTYPwqcfZjDWKlP/6cYcquxCew==', N'69c5f868-41d4-4fe9-96e1-c02763b978cf', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'37f35c6a-e584-4d06-931e-cb57752d4eb5', N'CanManageMovie')
               ");
        }
        
        public override void Down()
        {
        }
    }
}

namespace System_Controle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'62054c78-06bc-445d-8151-c4f3c3c4e9ef', N'issamostn@gmail.com', 0, N'AJpbCj4zc5UJYlwEARvgeI0T5XPXJSnIRyDfgzpZIdz6LiEwpcimM0vnYrNlb0Kpig==', N'12fb7ba4-1fab-4669-abb7-f95636cf3c03', NULL, 0, 0, NULL, 1, 0, N'issamostn@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'80711207-efe6-45bc-ae54-c12c0848377a', N'issam@yahoo.fr', 0, N'ACXEJ2aurT4ctNGFJoGjGeVuq8C7aC2gURR7wvRXCD87bc1TJJY6CAuyQ7is/Fb/uw==', N'5aaecc37-5c1f-427f-8fd2-56d52a7a1067', NULL, 0, 0, NULL, 1, 0, N'issam@yahoo.fr')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c8a175cb-1aed-476c-9ff1-cdbd92a11442', N'canManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'80711207-efe6-45bc-ae54-c12c0848377a', N'c8a175cb-1aed-476c-9ff1-cdbd92a11442')



");
        }
        
        public override void Down()
        {
        }
    }
}

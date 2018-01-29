namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'01e22d0c-50c9-4fed-9b18-88adde4b20f2', N'guest@mail.com', 0, N'AKxUzl75bAvmcG9Uw3D0u0ouE+UrOEnCpFbDJ7L61d+GwVmoC0SqIsLc+pPJ3bL4BA==', N'ba11c743-af10-4903-8750-a00802575243', NULL, 0, 0, NULL, 1, 0, N'guest@mail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'20a72e4c-bf80-4303-b7cf-92e71a0c039a', N'admin1@Vidly.com', 0, N'AOWD4A+1u+0mH1Ox7adM3oTLAqpielsF8M2nnLuVNCf5XQrlHoXEAY9l3f2RRGlwlw==', N'2840c589-542b-49b4-9969-b9f7d8723e2a', NULL, 0, 0, NULL, 1, 0, N'admin1@Vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8d803e04-23ce-4e44-86f4-d13576f5fff9', N'guest@vidly.com', 0, N'AL2GFy4vJzSV4sjuOGP/rfVe5vWW1KHq+hznvaNB5BDJGAnYe+KswtnlP3ZiRWtUkg==', N'00d288ad-2898-4afc-9554-dc38cb9e4882', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7d4b6398-bc2d-403d-8e82-99732820e54e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'20a72e4c-bf80-4303-b7cf-92e71a0c039a', N'7d4b6398-bc2d-403d-8e82-99732820e54e')

");
        }
        
        public override void Down()
        {
            
        }
    }
}

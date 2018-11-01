namespace VidlyEf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7fa10999-f7e9-459b-8e6d-fe54bf32517e', N'admin@vidly.com', 0, N'ACmraEBk1drCz3wsg9S2ds7r7CoPfBOHF9y5Ok2HiOdue7MyrEDfS3ICaJdOClYLVQ==', N'e2efea3a-82ab-4b6b-9848-9773f0d36eff', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b5e548fb-b8c2-4b99-bb88-5ee97dbaf14c', N'guest@vidly.com', 0, N'APHnzy3Wi17uLpx27YqNMJhNmCVZ9S8ymM9JAwgaxY/8L9zexf4NKFkBgeGRXUwI7w==', N'a8b745aa-a694-461d-83dc-e7884db588c6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'838b93dd-87a8-440b-b0cb-89d8c60bdf4b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7fa10999-f7e9-459b-8e6d-fe54bf32517e', N'838b93dd-87a8-440b-b0cb-89d8c60bdf4b')

                ");
        }
        
        public override void Down()
        {
        }
    }
}

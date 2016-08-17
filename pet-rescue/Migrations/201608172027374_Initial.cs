namespace pet_rescue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        PetAdoptionDate = c.DateTime(),
                        Housing = c.Int(),
                        AdoptionReason = c.Int(),
                        PetDonationDate = c.DateTime(),
                        Notes = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Int(nullable: false),
                        Weight = c.Double(nullable: false),
                        BirthDate = c.DateTime(),
                        EnteredShelterDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        IsNeuteredOrSpayed = c.Boolean(nullable: false),
                        EnteredDataDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                        ApplicationUserID = c.Int(nullable: false),
                        Size = c.Int(),
                        Color = c.Int(),
                        Color1 = c.Int(),
                        Size1 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Member_Id = c.String(maxLength: 128),
                        Breed_ID = c.Int(),
                        Breed_ID1 = c.Int(),
                        Adopter_Id = c.String(maxLength: 128),
                        Donor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.Member_Id)
                .ForeignKey("dbo.CatBreeds", t => t.Breed_ID)
                .ForeignKey("dbo.DogBreeds", t => t.Breed_ID1)
                .ForeignKey("dbo.AspNetUsers", t => t.Adopter_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Donor_Id)
                .Index(t => t.Member_Id)
                .Index(t => t.Breed_ID)
                .Index(t => t.Breed_ID1)
                .Index(t => t.Adopter_Id)
                .Index(t => t.Donor_Id);
            
            CreateTable(
                "dbo.CatBreeds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DogBreeds",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pets", "Donor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Pets", "Adopter_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Pets", "Breed_ID1", "dbo.DogBreeds");
            DropForeignKey("dbo.Pets", "Breed_ID", "dbo.CatBreeds");
            DropForeignKey("dbo.Pets", "Member_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.Pets", new[] { "Donor_Id" });
            DropIndex("dbo.Pets", new[] { "Adopter_Id" });
            DropIndex("dbo.Pets", new[] { "Breed_ID1" });
            DropIndex("dbo.Pets", new[] { "Breed_ID" });
            DropIndex("dbo.Pets", new[] { "Member_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.DogBreeds");
            DropTable("dbo.CatBreeds");
            DropTable("dbo.Pets");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}

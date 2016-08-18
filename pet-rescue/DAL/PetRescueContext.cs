using Microsoft.AspNet.Identity.EntityFramework;
using pet_rescue.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace pet_rescue.DAL
{
    public class PetRescueContext: IdentityDbContext<ApplicationUser>
    {
        public PetRescueContext(): base("PetRescueContext") { }

        public static PetRescueContext Create()
        {
            return new PetRescueContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

            // Customize table names in the database
            modelBuilder.Entity<ApplicationUser>().ToTable("Member").Property(p => p.Id).HasColumnName("MemberID");
            modelBuilder.Entity<IdentityUserRole>().ToTable("MemberRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("MemberLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("MemberClaim").Property(p => p.Id).HasColumnName("MemberClaimID");
            modelBuilder.Entity<IdentityRole>().ToTable("Role").Property(p => p.Id).HasColumnName("RoleID");
        }
    }
}
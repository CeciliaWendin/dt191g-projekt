using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace VetAB.Data
{
   public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
   {
      public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder)
      {
         builder.HasData(
            new IdentityRole
            {
               Id = "6ca78333-ad17-4662-9298-56a92e21556b",
               Name = "Administrator",
               NormalizedName = "ADMINISTRATOR"
            },
             new IdentityRole
            {
               Id = "6ca78449-af17-4662-7624-56a92e21556b",
               Name = "Employee",
               NormalizedName = "EMPLOYEE"
            },
             new IdentityRole
            {
               Id = "6ae78354-ff17-1675-8960-56a92e21559e",
               Name = "Customer",
               NormalizedName = "CUSTOMER"
            }
         );
      }
   }
}
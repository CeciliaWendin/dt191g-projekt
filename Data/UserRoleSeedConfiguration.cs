using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAB.Models;

namespace VetAB.Data
{
   public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
   {
      public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
      {
         builder.HasData(
            new IdentityUserRole<string>
            {
               RoleId = "6ca78333-ad17-4662-9298-56a92e21556b",
               UserId = "03d935ca-bba2-4167-8e9f-46414b62aa2f"
            },
            new IdentityUserRole<string>
            {
               RoleId = "6ca78449-af17-4662-7624-56a92e21556b",
               UserId = "548169a6-9a38-4d11-97ee-6316008da917"
            },
            new IdentityUserRole<string>
             {
               RoleId = "6ae78354-ff17-1675-8960-56a92e21559e",
               UserId = "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e"
            }
         );
      }
   }
}
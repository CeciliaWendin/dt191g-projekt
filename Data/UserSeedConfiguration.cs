using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAB.Models;

namespace VetAB.Data
{
   public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
   {
      public void Configure(EntityTypeBuilder<ApplicationUser> builder)
      {
         var hasher = new PasswordHasher<ApplicationUser>();
         builder.HasData(
            new ApplicationUser{
               Id = "03d935ca-bba2-4167-8e9f-46414b62aa2f",
               Email = "admin@testmail.com",
               NormalizedEmail = "ADMIN@TESTMAIL.COM",
               UserName = "admin@testmail.com",
               NormalizedUserName = "ADMIN@TESTMAIL.COM",
               FirstName = "Cecilia",
               LastName = "Wendin",
               EmailConfirmed = true,
               PasswordHash = hasher.HashPassword(null, "Miun2022!")
            },
             new ApplicationUser{
               Id = "548169a6-9a38-4d11-97ee-6316008da917",
               Email = "employee@testmail.com",
               NormalizedEmail = "EMPLOYEE@TESTMAIL.COM",
                UserName = "employee@testmail.com",
               NormalizedUserName = "EMPLOYEE@TESTMAIL.COM",
               FirstName = "Dennis",
               LastName = "Källgren",
               EmailConfirmed = true,
               PasswordHash = hasher.HashPassword(null, "Miun2022!")
            },
             new ApplicationUser{
               Id = "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
               Email = "customer@testmail.com",
               NormalizedEmail = "CUSTOMER@TESTMAIL.COM",
                UserName = "customer@testmail.com",
               NormalizedUserName = "CUSTOMER@TESTMAIL.COM",
               FirstName = "Arvid",
               LastName = "Svensson",
               EmailConfirmed = true,
               PasswordHash = hasher.HashPassword(null, "Miun2022!")
            }
         );
      }
   }
}
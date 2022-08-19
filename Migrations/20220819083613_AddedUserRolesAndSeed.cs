using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class AddedUserRolesAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ae78354-ff17-1675-8960-56a92e21559e", "b86e62ff-d1c4-47bc-8506-6d752a55bd72", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ca78333-ad17-4662-9298-56a92e21556b", "09d1c2f2-83ef-41bd-b7b7-4230b906359d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6ca78449-af17-4662-7624-56a92e21556b", "a58eeb4f-849f-4042-a12e-240dfcd7a962", "Emplyee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "03d935ca-bba2-4167-8e9f-46414b62aa2f", 0, null, "ad91ed6b-a925-4ae0-94a7-037d4c352fa5", "admin@testmail.com", false, "Cecilia", "Wendin", false, null, "ADMIN@TESTMAIL.COM", null, "AQAAAAEAACcQAAAAEGqYDepo/9whMW3vjxgGrxsSygZfb874oUvFnIg38Dm9XsEpNN48p28iYm4ifPkwTQ==", null, false, "eccb256e-8a53-4413-ac8a-795ff08e8c73", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e", 0, null, "e17bcaf7-e4a7-40f0-9918-92b35c41317f", "customer@testmail.com", false, "Arvid", "Svensson", false, null, "CUSTOMER@TESTMAIL.COM", null, "AQAAAAEAACcQAAAAEO5ObCV5bh0+Z2r7FcvtMdmhKXsvzncSDM6ZDY/DJc6NkVybQbXP6nS2VMPY+fyCPA==", null, false, "bfe3a2f0-764e-417e-8355-808efcddbbc5", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "548169a6-9a38-4d11-97ee-6316008da917", 0, null, "5b50c416-2e9a-4150-9e15-018f93f7e563", "employee@testmail.com", false, "Dennis", "Källgren", false, null, "EMPLOYEE@TESTMAIL.COM", null, "AQAAAAEAACcQAAAAEDcJxaZxBw6dazurDuR/WPyVQxr1XW4pFimw7rFZTaycoBl8fRi7l5ZYPAcX6i1m6A==", null, false, "26d6c307-6114-440c-bf8f-9fcdd95a4984", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6ca78333-ad17-4662-9298-56a92e21556b", "03d935ca-bba2-4167-8e9f-46414b62aa2f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6ae78354-ff17-1675-8960-56a92e21559e", "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6ca78449-af17-4662-7624-56a92e21556b", "548169a6-9a38-4d11-97ee-6316008da917" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ca78333-ad17-4662-9298-56a92e21556b", "03d935ca-bba2-4167-8e9f-46414b62aa2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ae78354-ff17-1675-8960-56a92e21559e", "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ca78449-af17-4662-7624-56a92e21556b", "548169a6-9a38-4d11-97ee-6316008da917" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae78354-ff17-1675-8960-56a92e21559e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78333-ad17-4662-9298-56a92e21556b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78449-af17-4662-7624-56a92e21556b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d935ca-bba2-4167-8e9f-46414b62aa2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917");
        }
    }
}

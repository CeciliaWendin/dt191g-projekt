using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class removedRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae78354-ff17-1675-8960-56a92e21559e",
                column: "ConcurrencyStamp",
                value: "bc34d89e-a0f2-49f9-be9e-100ae6a7cbc0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78333-ad17-4662-9298-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "cdaff7d3-fff8-4146-94c4-e172e9db292a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78449-af17-4662-7624-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "8fe2f3e3-73f9-49d0-8709-70b5ec3d0fa8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d935ca-bba2-4167-8e9f-46414b62aa2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a6ab5f7-1b89-493f-a13d-830a4f94d60e", "AQAAAAEAACcQAAAAEGPuHFbhY/1dzRTYdwgq7Nnb2xVZNShkilKEU/eAYlFDYECi1oIcQgq7xQ2BCIgi+A==", "2be21a07-88c4-4a7a-a1e4-7ca115dc9871" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b36187b-e07c-4bf9-aa06-1f7133f84dd1", "AQAAAAEAACcQAAAAEHD1RJHIR+e3pA9lWqoBA17EN0rKKUR3JetZEOw9oHEUxPHC0aI+9gLZtFmpfAKAww==", "196cdd41-2856-41d3-b8a0-ed93ff6e22c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03842ed4-0186-4928-8c80-7ad114a63bf1", "AQAAAAEAACcQAAAAELCJ+PDVOHO5/5paTsvWEZQ0yTtWjykYfMJ5OYO8C1ImhggeIYeZkhyIF9kTCXmVLw==", "63dd58b6-0922-458b-86e4-1b45799f077a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageName",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae78354-ff17-1675-8960-56a92e21559e",
                column: "ConcurrencyStamp",
                value: "01916a62-ef53-40c7-ac1d-411ed8ae8667");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78333-ad17-4662-9298-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "bd34f372-e434-44ae-ad1e-f060af188864");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78449-af17-4662-7624-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "e441bc82-c3d3-4937-a823-21e50b16c3c9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d935ca-bba2-4167-8e9f-46414b62aa2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb256306-3754-4b28-8952-0082c00ade1e", "AQAAAAEAACcQAAAAEJ5XtQ4ERb8cqtETgJpWjbACPDUZ+btUkjB4IV32WQ52VxKv4LOoxLQYDsiLqmv26g==", "3c9e96ae-ae56-4cc5-9ced-495746f0b684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a45c20f0-3908-4f90-aa65-eb6c141fd53b", "AQAAAAEAACcQAAAAEIgUg3Nwc8DzS1JdrcM0t7K/5WVRPeqJ7ONQGYybWN+ihZgfHk6MmqG18bk1M7S7GQ==", "3b2e656f-2999-4d5b-b2a9-e3ba3ad1a788" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dbf570a-ed10-409f-b44a-0e62afabdc1e", "AQAAAAEAACcQAAAAEE1qB2yhCHoK/R25i1EZvMfkaUFvnWVgeyhwKS/tqvpPte1Ie77K1bqzsrZVrWrwag==", "51f33ca7-9f0e-4deb-b756-ea0d016a1f8e" });
        }
    }
}

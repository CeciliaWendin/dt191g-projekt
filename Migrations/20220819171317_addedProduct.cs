using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class addedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageName = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae78354-ff17-1675-8960-56a92e21559e",
                column: "ConcurrencyStamp",
                value: "ec6e0c85-7c62-4fb0-8371-91a7e5b03e47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78333-ad17-4662-9298-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "58a80d28-0941-431a-84d6-0c33fb153e50");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78449-af17-4662-7624-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "3b102406-db12-475f-a65a-56768a42514e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d935ca-bba2-4167-8e9f-46414b62aa2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f334a67-3b8a-4c70-8338-c19aa9806457", "AQAAAAEAACcQAAAAEORmBgGnrGrNDvioERoaSqP+4f5xE+iGFAZIw0jGaRwjw3aJgBcRuBlZSRd7VDSHoA==", "aae8d66e-d543-4474-95fb-6d4c65f247a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1edacfac-b071-4adf-a713-a30e8b5a0df6", "AQAAAAEAACcQAAAAEDI1hg1HcuBq8Q9fsxW6hQDKfQpTI1n53o0Tuv+AoMZmK8nkyiqXPvsJOhkraaN24w==", "8140d7c6-b09b-4216-8ae4-c50222623301" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08d0eceb-d092-4130-965d-7ee0ce8536ad", "AQAAAAEAACcQAAAAECCUNCmLF0mBPQaNXq7KuWcj8a7VolLnUxFjDRG5HmmC9DOqK5/8qkZ6C2/4GXkIEw==", "8b097349-df1d-42f4-922a-b55eb708dabe" });
        }
    }
}

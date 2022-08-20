using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class addedProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae78354-ff17-1675-8960-56a92e21559e",
                column: "ConcurrencyStamp",
                value: "2e469790-5737-4799-9ed8-285f6956cf3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78333-ad17-4662-9298-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "fafb8d4f-3832-4442-8fe7-e8926d78b2c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78449-af17-4662-7624-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "80a19468-89e5-4471-bbbd-49e82baa20c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d935ca-bba2-4167-8e9f-46414b62aa2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49d78996-3552-4176-9fbd-1e8946505835", "AQAAAAEAACcQAAAAEIsA0MnG903g8yLNb2/BwYNU3XSROPEWj0sAH1etZpD/U1p+FUPKixwgrKJJK9WQew==", "b5fb4d18-2a9f-4ce4-bcc3-007f162a1337" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94ab8b58-efdc-47ed-9cb0-80e5cc68799a", "AQAAAAEAACcQAAAAEBhbQtT51g3gsdKeHiYglH2DaV8uTXe/sWI5wx1qKoN1en4+OGHF994NHJfjqmssYw==", "e701a140-4b0b-406e-94b5-1b38b84416a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d461f3f-83f1-46ac-b931-fe0b683958b3", "AQAAAAEAACcQAAAAENrkzU5Uh5zmU9H0HXmmclaH+amwxFsE12Db6ld8EoBkEl+fd+3FkRm/2f/DVzgkbg==", "0331d0d6-b908-4a40-ad8c-fe534d9cff16" });
        }
    }
}

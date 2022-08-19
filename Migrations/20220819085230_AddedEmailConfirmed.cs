using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class AddedEmailConfirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49d78996-3552-4176-9fbd-1e8946505835", true, "AQAAAAEAACcQAAAAEIsA0MnG903g8yLNb2/BwYNU3XSROPEWj0sAH1etZpD/U1p+FUPKixwgrKJJK9WQew==", "b5fb4d18-2a9f-4ce4-bcc3-007f162a1337" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94ab8b58-efdc-47ed-9cb0-80e5cc68799a", true, "AQAAAAEAACcQAAAAEBhbQtT51g3gsdKeHiYglH2DaV8uTXe/sWI5wx1qKoN1en4+OGHF994NHJfjqmssYw==", "e701a140-4b0b-406e-94b5-1b38b84416a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d461f3f-83f1-46ac-b931-fe0b683958b3", true, "AQAAAAEAACcQAAAAENrkzU5Uh5zmU9H0HXmmclaH+amwxFsE12Db6ld8EoBkEl+fd+3FkRm/2f/DVzgkbg==", "0331d0d6-b908-4a40-ad8c-fe534d9cff16" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae78354-ff17-1675-8960-56a92e21559e",
                column: "ConcurrencyStamp",
                value: "b7cff4b1-4d05-4ee3-b6fc-601424d15143");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78333-ad17-4662-9298-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "a64972a3-f1a1-44a0-ab74-be7475b93d6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78449-af17-4662-7624-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "cc07d911-5821-4794-a2a4-8820098b5450");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d935ca-bba2-4167-8e9f-46414b62aa2f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65a5ee93-5f7f-4f3b-82e8-9ff6bd053325", false, "AQAAAAEAACcQAAAAEPJFHB5ySh2B/GlJwoAA+iC1f/3ndN9xfNtJh0pRMSnBueDb5G8dXAqvbFS+lNQ6Cg==", "33f5def9-3ac1-4009-9cb0-5fb4e94be9fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69eae036-f2e5-45c9-ae88-15e13a716c88", false, "AQAAAAEAACcQAAAAEFuE9b01DWIwwrrMsLioUzROPucCepFo8J1ZmiTMhUaMU6/GTf/cMLDsg3V+6djQrQ==", "5f327ac7-ef3d-448f-8837-4bbef299d483" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c42288e3-ed59-4c26-9158-59cc550ae17c", false, "AQAAAAEAACcQAAAAEOnSf+uPMI+FWRcXtGLDh9YY9tN65nevE4WeXqSxoe/Ma8e6G169+q2Jcqkj+hQTcg==", "627a3811-e888-4fa6-9101-736a1b8cf141" });
        }
    }
}

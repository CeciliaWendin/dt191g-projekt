using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class CorrectedUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "65a5ee93-5f7f-4f3b-82e8-9ff6bd053325", "ADMIN@TESTMAIL.COM", "AQAAAAEAACcQAAAAEPJFHB5ySh2B/GlJwoAA+iC1f/3ndN9xfNtJh0pRMSnBueDb5G8dXAqvbFS+lNQ6Cg==", "33f5def9-3ac1-4009-9cb0-5fb4e94be9fb", "admin@testmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "69eae036-f2e5-45c9-ae88-15e13a716c88", "CUSTOMER@TESTMAIL.COM", "AQAAAAEAACcQAAAAEFuE9b01DWIwwrrMsLioUzROPucCepFo8J1ZmiTMhUaMU6/GTf/cMLDsg3V+6djQrQ==", "5f327ac7-ef3d-448f-8837-4bbef299d483", "customer@testmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c42288e3-ed59-4c26-9158-59cc550ae17c", "EMPLOYEE@TESTMAIL.COM", "AQAAAAEAACcQAAAAEOnSf+uPMI+FWRcXtGLDh9YY9tN65nevE4WeXqSxoe/Ma8e6G169+q2Jcqkj+hQTcg==", "627a3811-e888-4fa6-9101-736a1b8cf141", "employee@testmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae78354-ff17-1675-8960-56a92e21559e",
                column: "ConcurrencyStamp",
                value: "084a1678-24a8-4b68-ae55-f136fbf8a4e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78333-ad17-4662-9298-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "2e64734e-1e83-41b8-b134-e6abb96b3203");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78449-af17-4662-7624-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "d58efccc-2003-445a-b4dc-f56066f435e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d935ca-bba2-4167-8e9f-46414b62aa2f",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a881083a-1070-4f1f-afad-c5c6e78c1647", null, "AQAAAAEAACcQAAAAELbn5/VTyuhcsFzwUu+QzWKKLvKAaVM0VB6FwwC1Ad6kN5vRREHYkhrWkQs/foFlEw==", "fd88fa10-5197-48f3-8cd4-3f2801e2cc6c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4faa4a14-5757-4b36-bcef-e82c29911418", null, "AQAAAAEAACcQAAAAEH6Wb358eDzT3AUf7vFoxNG0/uidsIrqnVxcw+MQC/VmWIomRVi1Sk7pNfXgmkJ24Q==", "019d0dc0-d1c4-41be-b811-6bf907dd0ebf", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c2e27ab0-9f69-41e8-91da-a61f528b4056", null, "AQAAAAEAACcQAAAAEBBKS7YwKfJKsiRCsvPOn7C6VtQ+Lc3JZ3GOsdswCzfwk0p+q+R9szwqLpchH/OrpQ==", "e9127204-8b6c-4283-a918-3f86838ab873", null });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class CorrectedName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "d58efccc-2003-445a-b4dc-f56066f435e4", "Employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d935ca-bba2-4167-8e9f-46414b62aa2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a881083a-1070-4f1f-afad-c5c6e78c1647", "AQAAAAEAACcQAAAAELbn5/VTyuhcsFzwUu+QzWKKLvKAaVM0VB6FwwC1Ad6kN5vRREHYkhrWkQs/foFlEw==", "fd88fa10-5197-48f3-8cd4-3f2801e2cc6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4faa4a14-5757-4b36-bcef-e82c29911418", "AQAAAAEAACcQAAAAEH6Wb358eDzT3AUf7vFoxNG0/uidsIrqnVxcw+MQC/VmWIomRVi1Sk7pNfXgmkJ24Q==", "019d0dc0-d1c4-41be-b811-6bf907dd0ebf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2e27ab0-9f69-41e8-91da-a61f528b4056", "AQAAAAEAACcQAAAAEBBKS7YwKfJKsiRCsvPOn7C6VtQ+Lc3JZ3GOsdswCzfwk0p+q+R9szwqLpchH/OrpQ==", "e9127204-8b6c-4283-a918-3f86838ab873" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ae78354-ff17-1675-8960-56a92e21559e",
                column: "ConcurrencyStamp",
                value: "b86e62ff-d1c4-47bc-8506-6d752a55bd72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78333-ad17-4662-9298-56a92e21556b",
                column: "ConcurrencyStamp",
                value: "09d1c2f2-83ef-41bd-b7b7-4230b906359d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ca78449-af17-4662-7624-56a92e21556b",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "a58eeb4f-849f-4042-a12e-240dfcd7a962", "Emplyee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d935ca-bba2-4167-8e9f-46414b62aa2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad91ed6b-a925-4ae0-94a7-037d4c352fa5", "AQAAAAEAACcQAAAAEGqYDepo/9whMW3vjxgGrxsSygZfb874oUvFnIg38Dm9XsEpNN48p28iYm4ifPkwTQ==", "eccb256e-8a53-4413-ac8a-795ff08e8c73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5fcfe9-c3ed-46c4-ba01-4414fd6f356e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e17bcaf7-e4a7-40f0-9918-92b35c41317f", "AQAAAAEAACcQAAAAEO5ObCV5bh0+Z2r7FcvtMdmhKXsvzncSDM6ZDY/DJc6NkVybQbXP6nS2VMPY+fyCPA==", "bfe3a2f0-764e-417e-8355-808efcddbbc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548169a6-9a38-4d11-97ee-6316008da917",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b50c416-2e9a-4150-9e15-018f93f7e563", "AQAAAAEAACcQAAAAEDcJxaZxBw6dazurDuR/WPyVQxr1XW4pFimw7rFZTaycoBl8fRi7l5ZYPAcX6i1m6A==", "26d6c307-6114-440c-bf8f-9fcdd95a4984" });
        }
    }
}

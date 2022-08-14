using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAnimals_Animals_AnimalId",
                table: "CustomerAnimals");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAnimals_Customers_CustomerId",
                table: "CustomerAnimals");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerAnimals",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "CustomerAnimals",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAnimals_Animals_AnimalId",
                table: "CustomerAnimals",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAnimals_Customers_CustomerId",
                table: "CustomerAnimals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAnimals_Animals_AnimalId",
                table: "CustomerAnimals");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAnimals_Customers_CustomerId",
                table: "CustomerAnimals");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "CustomerAnimals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "CustomerAnimals",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAnimals_Animals_AnimalId",
                table: "CustomerAnimals",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAnimals_Customers_CustomerId",
                table: "CustomerAnimals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

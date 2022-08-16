using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class ChangesToOwnership : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ownerships_Animals_AnimalId",
                table: "Ownerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownerships_Customers_CustomerId",
                table: "Ownerships");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Ownerships",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Ownerships",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Ownerships_Animals_AnimalId",
                table: "Ownerships",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ownerships_Customers_CustomerId",
                table: "Ownerships",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ownerships_Animals_AnimalId",
                table: "Ownerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownerships_Customers_CustomerId",
                table: "Ownerships");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Ownerships",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Ownerships",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ownerships_Animals_AnimalId",
                table: "Ownerships",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ownerships_Customers_CustomerId",
                table: "Ownerships",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

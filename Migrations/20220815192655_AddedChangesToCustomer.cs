using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class AddedChangesToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Customers_CustomerId",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_CustomerId",
                table: "Animals");

            migrationBuilder.AddColumn<int>(
                name: "Animals",
                table: "Animals",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Animals_Animals",
                table: "Animals",
                column: "Animals");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Customers_Animals",
                table: "Animals",
                column: "Animals",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Customers_Animals",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_Animals",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Animals",
                table: "Animals");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CustomerId",
                table: "Animals",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Customers_CustomerId",
                table: "Animals",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class MoreChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Products_ProductId",
                table: "Visits");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Visits_ProductId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Visits");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Visits",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "VisitType",
                table: "Visits",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "VisitType",
                table: "Visits");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Visits",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visits_ProductId",
                table: "Visits",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Products_ProductId",
                table: "Visits",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

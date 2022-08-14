using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class ChengesToModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Animals_AnimalId",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Customers_CustomerId",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Product_ProductId",
                table: "Visit");

            migrationBuilder.DropTable(
                name: "CustomerAnimals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visit",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Visit",
                newName: "Visits");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_ProductId",
                table: "Visits",
                newName: "IX_Visits_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_CustomerId",
                table: "Visits",
                newName: "IX_Visits_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_AnimalId",
                table: "Visits",
                newName: "IX_Visits_AnimalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visits",
                table: "Visits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Animals_AnimalId",
                table: "Visits",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Customers_CustomerId",
                table: "Visits",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Products_ProductId",
                table: "Visits",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Animals_AnimalId",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Customers_CustomerId",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Products_ProductId",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visits",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Visits",
                newName: "Visit");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_ProductId",
                table: "Visit",
                newName: "IX_Visit_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_CustomerId",
                table: "Visit",
                newName: "IX_Visit_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_AnimalId",
                table: "Visit",
                newName: "IX_Visit_AnimalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visit",
                table: "Visit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CustomerAnimals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimalId = table.Column<int>(type: "INTEGER", nullable: true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAnimals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAnimals_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CustomerAnimals_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAnimals_AnimalId",
                table: "CustomerAnimals",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAnimals_CustomerId",
                table: "CustomerAnimals",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Animals_AnimalId",
                table: "Visit",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Customers_CustomerId",
                table: "Visit",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Product_ProductId",
                table: "Visit",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

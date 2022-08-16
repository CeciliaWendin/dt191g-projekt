using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class AddedListToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_Animals_AnimalId",
                table: "Ownership");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_Customers_CustomerId",
                table: "Ownership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ownership",
                table: "Ownership");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Ownership",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Ownership",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Ownership",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ownership",
                table: "Ownership",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ownership_CustomerId",
                table: "Ownership",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ownership_Animals_AnimalId",
                table: "Ownership",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ownership_Customers_CustomerId",
                table: "Ownership",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_Animals_AnimalId",
                table: "Ownership");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_Customers_CustomerId",
                table: "Ownership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ownership",
                table: "Ownership");

            migrationBuilder.DropIndex(
                name: "IX_Ownership_CustomerId",
                table: "Ownership");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Ownership",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
                table: "Ownership",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Ownership",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ownership",
                table: "Ownership",
                columns: new[] { "CustomerId", "AnimalId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ownership_Animals_AnimalId",
                table: "Ownership",
                column: "AnimalId",
                principalTable: "Animals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ownership_Customers_CustomerId",
                table: "Ownership",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

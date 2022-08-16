using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetAB.Migrations
{
    public partial class AddedOwnershipModelToBind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Customers_Animals",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_Animals_AnimalId",
                table: "Ownership");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownership_Customers_CustomerId",
                table: "Ownership");

            migrationBuilder.DropIndex(
                name: "IX_Animals_Animals",
                table: "Animals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ownership",
                table: "Ownership");

            migrationBuilder.DropColumn(
                name: "Animals",
                table: "Animals");

            migrationBuilder.RenameTable(
                name: "Ownership",
                newName: "Ownerships");

            migrationBuilder.RenameIndex(
                name: "IX_Ownership_CustomerId",
                table: "Ownerships",
                newName: "IX_Ownerships_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Ownership_AnimalId",
                table: "Ownerships",
                newName: "IX_Ownerships_AnimalId");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ownerships",
                table: "Ownerships",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Customers_CustomerId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownerships_Animals_AnimalId",
                table: "Ownerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownerships_Customers_CustomerId",
                table: "Ownerships");

            migrationBuilder.DropIndex(
                name: "IX_Animals_CustomerId",
                table: "Animals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ownerships",
                table: "Ownerships");

            migrationBuilder.RenameTable(
                name: "Ownerships",
                newName: "Ownership");

            migrationBuilder.RenameIndex(
                name: "IX_Ownerships_CustomerId",
                table: "Ownership",
                newName: "IX_Ownership_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Ownerships_AnimalId",
                table: "Ownership",
                newName: "IX_Ownership_AnimalId");

            migrationBuilder.AddColumn<int>(
                name: "Animals",
                table: "Animals",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Ownership",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "AnimalId",
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
                name: "IX_Animals_Animals",
                table: "Animals",
                column: "Animals");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Customers_Animals",
                table: "Animals",
                column: "Animals",
                principalTable: "Customers",
                principalColumn: "Id");

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
    }
}

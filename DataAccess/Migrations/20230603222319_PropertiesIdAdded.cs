using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PropertiesIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarProperties_CarPropertiesId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CarPropertiesId",
                table: "Cars",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarProperties_CarPropertiesId",
                table: "Cars",
                column: "CarPropertiesId",
                principalTable: "CarProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarProperties_CarPropertiesId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CarPropertiesId",
                table: "Cars",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarProperties_CarPropertiesId",
                table: "Cars",
                column: "CarPropertiesId",
                principalTable: "CarProperties",
                principalColumn: "Id");
        }
    }
}

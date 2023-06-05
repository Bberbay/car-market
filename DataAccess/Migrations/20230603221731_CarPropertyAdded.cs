using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CarPropertyAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarPropertiesId",
                table: "Cars",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Color = table.Column<string>(type: "text", nullable: false),
                    FuelType = table.Column<short>(type: "smallint", nullable: false),
                    Gear = table.Column<short>(type: "smallint", nullable: false),
                    EnginePower = table.Column<short>(type: "smallint", nullable: false),
                    EngineCapacity = table.Column<short>(type: "smallint", nullable: false),
                    HeadlampFog = table.Column<short>(type: "smallint", nullable: false),
                    FoldingMirros = table.Column<short>(type: "smallint", nullable: false),
                    ParkingSensor = table.Column<short>(type: "smallint", nullable: false),
                    CentralLock = table.Column<short>(type: "smallint", nullable: false),
                    SunRoof = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarProperties", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarPropertiesId",
                table: "Cars",
                column: "CarPropertiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarProperties_CarPropertiesId",
                table: "Cars",
                column: "CarPropertiesId",
                principalTable: "CarProperties",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarProperties_CarPropertiesId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "CarProperties");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarPropertiesId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarPropertiesId",
                table: "Cars");
        }
    }
}

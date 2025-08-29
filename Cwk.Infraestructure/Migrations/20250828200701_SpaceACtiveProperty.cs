using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwk.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class SpaceACtiveProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "Spaces",
                newName: "IsActive");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Spaces",
                newName: "IsAvailable");
        }
    }
}

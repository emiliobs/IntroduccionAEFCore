using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroduccionAEFCore.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnCInes",
                table: "Peliculas",
                newName: "EnCines");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnCines",
                table: "Peliculas",
                newName: "EnCInes");
        }
    }
}

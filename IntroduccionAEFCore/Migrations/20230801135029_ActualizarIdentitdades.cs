using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroduccionAEFCore.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarIdentitdades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Orden",
                table: "PiliculasActores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Orden",
                table: "PiliculasActores");
        }
    }
}

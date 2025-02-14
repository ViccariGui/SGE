using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SGE.Migrations
{
    /// <inheritdoc />
    public partial class NotasCorrigida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nota",
                table: "Notas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Notas");
        }
    }
}

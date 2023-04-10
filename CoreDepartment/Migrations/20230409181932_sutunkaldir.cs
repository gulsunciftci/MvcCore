using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartment.Migrations
{
    /// <inheritdoc />
    public partial class sutunkaldir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detay",
                table: "Departmanlars");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "detay",
                table: "Departmanlars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

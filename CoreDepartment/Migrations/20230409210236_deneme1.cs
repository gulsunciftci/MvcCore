using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartment.Migrations
{
    /// <inheritdoc />
    public partial class deneme1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departid",
                table: "personel",
                nullable: true
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
              name: "departid",
              table: "personel",
              nullable: true
              );
        }
    }
}

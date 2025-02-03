using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddingAgeAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Age",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Secundus_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstPlaceName",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "SecondPlaceName",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "ThirdPlaceName",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "ErnstScore",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PetterScore",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SondreScore",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ErnstScore",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "PetterScore",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "SondreScore",
                table: "Games");

            migrationBuilder.AddColumn<string>(
                name: "FirstPlaceName",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondPlaceName",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThirdPlaceName",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

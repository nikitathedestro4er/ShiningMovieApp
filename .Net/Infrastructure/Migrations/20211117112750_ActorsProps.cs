using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ActorsProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Actor",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Actor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Image", "Rating", "Slug", "Year" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/e/ec/Jack_Nicholson_2001.jpg", 13.0, "jack-nicholson--1", 1937 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Actor");
        }
    }
}

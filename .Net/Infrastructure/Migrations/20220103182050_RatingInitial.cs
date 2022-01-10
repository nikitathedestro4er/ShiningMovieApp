using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class RatingInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Customer_CustomerId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ReplyComment");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "ReplyComment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Comment");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "ReplyComment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(3314), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4376), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4380), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4382), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4384), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4385), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4387), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4389), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4391), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4393), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4396), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4398), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4400), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4402), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4403), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4430), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4433), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4435), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4436), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4438), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4439) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4440), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4442), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4443), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4445), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4447), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4449), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4452), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4453), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4455), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4457), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4458), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4460), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4461) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4462), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4464), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4466), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4467), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4469), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4471), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4472), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4474), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4476), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4478), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4480), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4482), new DateTime(2022, 1, 3, 18, 20, 49, 653, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(1759), new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4183), new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4191), new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4195), new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4199), new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4204), new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4207), new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4211), new DateTime(2022, 1, 3, 18, 20, 49, 661, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(1603), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2323), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2327), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2330), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2332), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2335), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2337), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2339), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2342), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2344), new DateTime(2022, 1, 3, 18, 20, 49, 667, DateTimeKind.Utc).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(3488), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4788), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4792), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4794), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4796), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4797), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4799), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4801), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4803), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4804), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4806), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4807), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4810), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4811), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4813), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4814), new DateTime(2022, 1, 3, 18, 20, 49, 674, DateTimeKind.Utc).AddTicks(4815) });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Customer_CustomerId",
                table: "Comment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Customer_CustomerId",
                table: "Comment");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "ReplyComment");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ReplyComment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "ReplyComment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Comment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(2255), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3180), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3183), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3185), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3187), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3188), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3190), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3191), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3193), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3194), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3196), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3198), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3200), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3201), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3203), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3204), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3206), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3207), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3209), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3210), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3212), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3213), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3215), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3216), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3218), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3220), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3222), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3223), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3225), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3226), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3228), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3230), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3231), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3301), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3303), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3304), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3306), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3307), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3309), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3310), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3313), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3315), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3316), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3318), new DateTime(2021, 12, 28, 11, 25, 17, 556, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(8861), new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9825), new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9829), new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9853), new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9855), new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9857), new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9859), new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9860), new DateTime(2021, 12, 28, 11, 25, 17, 563, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2295), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2661), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2663), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2665), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2666), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2667), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2668), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2670), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2671), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2672), new DateTime(2021, 12, 28, 11, 25, 17, 566, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 572, DateTimeKind.Utc).AddTicks(9034), new DateTime(2021, 12, 28, 11, 25, 17, 572, DateTimeKind.Utc).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(348), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(352), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(354), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(356), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(357), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(359), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(361), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(384), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(387), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(388), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(390), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(392), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(393), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(395), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(396), new DateTime(2021, 12, 28, 11, 25, 17, 573, DateTimeKind.Utc).AddTicks(397) });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Customer_CustomerId",
                table: "Comment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

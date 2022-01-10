using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CommentInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Dislike = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(4267), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5315), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5319), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5321), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5324), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5326), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5328), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5329), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5331), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5333), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5335), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5336), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5338), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5340), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5341), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5343), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5345), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5347), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5348), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5350), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5352), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5354), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5356), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5358), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5360), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "Image", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5361), "Frederic Diefenthal--c5cb3a61-5bd5-4a21-9dba-a3708c1a5ba9.jpg", new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5363), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5365), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5366), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5368), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5370), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5372), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5373), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5375), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5377), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5379), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5380), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5382), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5384), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5385), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5387), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5389), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5390), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5392), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 610, DateTimeKind.Utc).AddTicks(9416), new DateTime(2021, 12, 15, 15, 56, 33, 610, DateTimeKind.Utc).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(423), new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(427), new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(429), new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(431), new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(432), new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(434), new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(436), new DateTime(2021, 12, 15, 15, 56, 33, 611, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5069), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5493), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5495), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5497), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5498), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5500), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5501) });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CreationTime", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5502), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5502), "Animation" },
                    { 10, new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5506), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5506), "Adventure" },
                    { 9, new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5504), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5505), "History" },
                    { 8, new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5503), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5504), "Drama" }
                });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(6269), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8230), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8236), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8238), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8241), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8247), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8249), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8252), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8255), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8257), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8260), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8262), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8265), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8268), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8270), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8273), new DateTime(2021, 12, 15, 15, 56, 33, 621, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MovieId",
                table: "Comment",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 45, DateTimeKind.Utc).AddTicks(9241), new DateTime(2021, 11, 25, 14, 37, 36, 45, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(145), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(148), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(150), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(151), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(154), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(155), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(157), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(158), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(160), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(161), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(163), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(164), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(166), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(167), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(169), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(170), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(172), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(173), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(175), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(176), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(179), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(180), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(182), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(183), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "Image", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(185), "Frédéric Diefenthal--c5cb3a61-5bd5-4a21-9dba-a3708c1a5ba9.jpg", new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(186), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(188), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(189), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(191), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(192), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(194), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(195), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(197), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(198), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(199), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(202), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(203), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(205), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(206), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(207), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(209), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(210), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(212), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(5874), new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6791), new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6794), new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6796), new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6797), new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6799), new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6801), new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6802), new DateTime(2021, 11, 25, 14, 37, 36, 51, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9626), new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9992), new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9994), new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9995), new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9997), new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9998), new DateTime(2021, 11, 25, 14, 37, 36, 53, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(4813), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6169), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6173), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6176), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6178), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6179), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6181), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6183), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6184), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6186), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6188), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6189), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6217), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6220), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6221), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6223), new DateTime(2021, 11, 25, 14, 37, 36, 59, DateTimeKind.Utc).AddTicks(6223) });
        }
    }
}

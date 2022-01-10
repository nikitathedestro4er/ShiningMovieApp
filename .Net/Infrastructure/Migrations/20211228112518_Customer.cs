using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ReplyComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreationTime", "Image", "ModifiedDate", "UserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack Nicholson--928401a8-56b7-4b88-beb6-90e19399789c.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "20befc7a-f889-43f4-9db0-44af52b225ee" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CustomerId",
                table: "Comment",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Customer_CustomerId",
                table: "Comment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Customer_CustomerId",
                table: "Comment");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Comment_CustomerId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ReplyComment");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Comment");

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(253), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1370), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1374), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1376), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1378), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1380), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1382), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1384), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1385), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1387), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1389), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1392), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1393), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1395), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1397), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1398), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1400), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1402), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1404), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1405), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1407), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1409), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1410), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1412), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1414), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1416), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1417), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1420), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1422), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1424), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1425), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1427), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1429), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1430), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1432), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1434), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1435), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1437), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1439), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1440), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1442), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1444), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1446), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1446) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1448), new DateTime(2021, 12, 22, 14, 32, 21, 318, DateTimeKind.Utc).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(5980), new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7068), new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7072), new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7074), new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7076), new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7078), new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7080), new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7106), new DateTime(2021, 12, 22, 14, 32, 21, 330, DateTimeKind.Utc).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8060), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8517), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8519), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8521), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8522), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8523), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8525), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8527), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8528), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8529), new DateTime(2021, 12, 22, 14, 32, 21, 333, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(6462), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8006), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8010), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8012), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8014), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8016), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8018), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8020), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8023), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8025), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8027), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8029), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8031), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8032), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8034), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8039), new DateTime(2021, 12, 22, 14, 32, 21, 343, DateTimeKind.Utc).AddTicks(8040) });
        }
    }
}

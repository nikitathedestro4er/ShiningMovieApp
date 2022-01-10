using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class BirthdayAndLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "Actor");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Length",
                table: "Movie",
                type: "time(0)",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Director",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Director",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Actor",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(185), new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(185) });

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
                columns: new[] { "CreationTime", "Image", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(199), "Bill Skarsgard--346a9d0e-6157-498c-a2c7-cc2b087491c6.jpg", new DateTime(2021, 11, 25, 14, 37, 36, 46, DateTimeKind.Utc).AddTicks(200) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Length",
                table: "Movie",
                type: "time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time(0)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Director",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Director",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Actor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Actor",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

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
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(926), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1820), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1823), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1825), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1826), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1828), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1829), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1831), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1832), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1835), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1837), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1839), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1840), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1842), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1843), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1845), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1846), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1848), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1849), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1851), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1852), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1854), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1855), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1857), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1858), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1859), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1862), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1863), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1865), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1866), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1868), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1869), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1871), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1872), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1874), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationTime", "Image", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1875), "Bill Skarsgård--346a9d0e-6157-498c-a2c7-cc2b087491c6.jpg", new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1877), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1878), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1880), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1881), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1883), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1884), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1886), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1887), new DateTime(2021, 11, 22, 15, 15, 27, 14, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 19, DateTimeKind.Utc).AddTicks(9672), new DateTime(2021, 11, 22, 15, 15, 27, 19, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(536), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(539), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(540), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(542), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(544), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(545), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(547), new DateTime(2021, 11, 22, 15, 15, 27, 20, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(1826), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2190), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2192), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2193), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2195), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2196), new DateTime(2021, 11, 22, 15, 15, 27, 22, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(6016), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7261), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7265), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7266), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7269), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7271), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7273), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7274), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7277), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7278), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7280), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7282), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7284), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7285), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7287), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7289), new DateTime(2021, 11, 22, 15, 15, 27, 27, DateTimeKind.Utc).AddTicks(7289) });
        }
    }
}

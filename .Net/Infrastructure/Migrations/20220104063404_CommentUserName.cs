using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CommentUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "ReplyComment",
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
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(7082), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8064), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8067), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8069), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8071), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8073), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8075), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8076), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8078), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8079), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8081), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8083), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8084), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8086), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8087), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8089), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8090), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8092), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8095), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8096), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8098), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8099), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8101), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8102), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8104), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8105), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8108), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8109), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8111), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8112), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8114), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8115), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8117), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8118), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8120), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8121), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8123), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8124), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8126), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8127), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8129), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8130), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8132), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8133), new DateTime(2022, 1, 4, 6, 34, 3, 660, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(2767), new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3751), new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3755), new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3757), new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3759), new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3760), new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3762), new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3764), new DateTime(2022, 1, 4, 6, 34, 3, 668, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(5851), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6221), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6223), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6224), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6225), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6227), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6228), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6229), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6230), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6231), new DateTime(2022, 1, 4, 6, 34, 3, 670, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 676, DateTimeKind.Utc).AddTicks(9771), new DateTime(2022, 1, 4, 6, 34, 3, 676, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1047), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1051), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1053), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1055), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1057), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1058), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1060), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1062), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1063), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1065), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1067), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1068), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1070), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1071), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1073), new DateTime(2022, 1, 4, 6, 34, 3, 677, DateTimeKind.Utc).AddTicks(1074) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "ReplyComment");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Comment");

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
        }
    }
}

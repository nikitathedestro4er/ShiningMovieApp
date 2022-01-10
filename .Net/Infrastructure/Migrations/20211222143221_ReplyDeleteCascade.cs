using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ReplyDeleteCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_Comment_CommentId",
                table: "Replies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Replies",
                table: "Replies");

            migrationBuilder.RenameTable(
                name: "Replies",
                newName: "ReplyComment");

            migrationBuilder.RenameIndex(
                name: "IX_Replies_CommentId",
                table: "ReplyComment",
                newName: "IX_ReplyComment_CommentId");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comment",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "ReplyComment",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReplyComment",
                table: "ReplyComment",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyComment_Comment_CommentId",
                table: "ReplyComment",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReplyComment_Comment_CommentId",
                table: "ReplyComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReplyComment",
                table: "ReplyComment");

            migrationBuilder.RenameTable(
                name: "ReplyComment",
                newName: "Replies");

            migrationBuilder.RenameIndex(
                name: "IX_ReplyComment_CommentId",
                table: "Replies",
                newName: "IX_Replies_CommentId");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Replies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Replies",
                table: "Replies",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(2526), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4910), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4919), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4924), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4928), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4933), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4936), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4940), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4944), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4949), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4954), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4957), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4961), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4968), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4971), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4975), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4978), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4982), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4985), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4989), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4992), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4996), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5000), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5003), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5007), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5011), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5016), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5019), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5023), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5026), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5030), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5033), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5037), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5040), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5044), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5047), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5051), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5054), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5057), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5061), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5064), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5068), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5071), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5075), new DateTime(2021, 12, 21, 14, 18, 13, 848, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(3943), new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6075), new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6082), new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6086), new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6089), new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6093), new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6096), new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6100), new DateTime(2021, 12, 21, 14, 18, 13, 865, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(139), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1115), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1121), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1124), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1127), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1130), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1132), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1135), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1138), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1141), new DateTime(2021, 12, 21, 14, 18, 13, 871, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 886, DateTimeKind.Utc).AddTicks(8108), new DateTime(2021, 12, 21, 14, 18, 13, 886, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1099), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1107), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1111), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1115), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1119), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1123), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1127), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1130), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1135), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1140), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1144), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1147), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1151), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1155), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1158), new DateTime(2021, 12, 21, 14, 18, 13, 887, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_Comment_CommentId",
                table: "Replies",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

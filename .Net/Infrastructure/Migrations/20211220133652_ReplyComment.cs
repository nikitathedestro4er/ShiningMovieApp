using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ReplyComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dislike",
                table: "Comment",
                newName: "Dislikes");

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Dislikes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Replies_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(2904), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4043), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4048), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4055), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4057), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4059), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4061), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4063), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4065), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4076), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4078), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4090), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4092), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4094), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4096), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4097), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4107), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4109), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4111), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4117), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4119), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4121), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4123), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4125), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4126), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4129), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4131), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4134), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4136), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4138), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4140), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4141), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4143), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4145), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4147), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4149), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4151), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4152), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4154), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4156), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4158), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4160), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4161), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4163), new DateTime(2021, 12, 20, 13, 36, 51, 485, DateTimeKind.Utc).AddTicks(4164) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 493, DateTimeKind.Utc).AddTicks(9324), new DateTime(2021, 12, 20, 13, 36, 51, 493, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(515), new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(519), new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(521), new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(523), new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(525), new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(527), new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Director",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(529), new DateTime(2021, 12, 20, 13, 36, 51, 494, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(7582), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8067), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8070), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8071), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8073), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8074), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8076), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8106), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8108), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8110), new DateTime(2021, 12, 20, 13, 36, 51, 496, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 503, DateTimeKind.Utc).AddTicks(9564), new DateTime(2021, 12, 20, 13, 36, 51, 503, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1119), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1124), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1127), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1129), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1131), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1133), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1135), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1137), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1140), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1142), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1144), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1146), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1148), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1150), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1152), new DateTime(2021, 12, 20, 13, 36, 51, 504, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.CreateIndex(
                name: "IX_Replies_CommentId",
                table: "Replies",
                column: "CommentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.RenameColumn(
                name: "Dislikes",
                table: "Comment",
                newName: "Dislike");

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
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5361), new DateTime(2021, 12, 15, 15, 56, 33, 603, DateTimeKind.Utc).AddTicks(5362) });

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

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5502), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5503), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5504), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5506), new DateTime(2021, 12, 15, 15, 56, 33, 613, DateTimeKind.Utc).AddTicks(5506) });

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
        }
    }
}

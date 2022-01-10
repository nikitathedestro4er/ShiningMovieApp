using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class CommentsDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dislikes",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Replies");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Replies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Comment");

            migrationBuilder.AddColumn<int>(
                name: "Dislikes",
                table: "Replies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Replies",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}

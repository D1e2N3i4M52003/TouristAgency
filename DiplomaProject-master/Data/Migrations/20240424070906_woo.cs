using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class woo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: new Guid("cf6f2ea9-6a78-4d0d-a7bf-bd00ef67e374"));

            migrationBuilder.DeleteData(
                table: "Excursions",
                keyColumn: "Id",
                keyValue: new Guid("57ba3b75-3e64-45f6-a58e-75220c139eff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ec90d27-6a1f-43b5-bbbf-c22f52d7e381"));

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "City", "Description", "Name" },
                values: new object[] { new Guid("40051350-3229-489d-8a6b-01ecce5a0698"), "Plovdiv", "In Plovdiv", "Ancient Theathre" });

            migrationBuilder.InsertData(
                table: "Excursions",
                columns: new[] { "Id", "CreationDate", "EndsOnDate", "Name", "Price", "StartsOnDate" },
                values: new object[] { new Guid("12c920ee-ca2e-4628-a6d4-585df692b55e"), new DateTime(2024, 4, 24, 9, 9, 6, 134, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), "Plovdiv", 14m, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Email", "Firstname", "Lastname", "PasswordHash", "Role", "Username" },
                values: new object[] { new Guid("0ebb6243-c33a-406a-9d81-72f3f1cc9cd0"), new DateTime(2024, 4, 24, 9, 9, 5, 987, DateTimeKind.Local).AddTicks(9572), "admin@gmail.com", "Ad", "min", "$2a$11$yHwgb.AnMuBcrLs8YT7CwuVLE2vYYCeF8EX24Al5L2gp7UtIjoqk6", 0, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: new Guid("40051350-3229-489d-8a6b-01ecce5a0698"));

            migrationBuilder.DeleteData(
                table: "Excursions",
                keyColumn: "Id",
                keyValue: new Guid("12c920ee-ca2e-4628-a6d4-585df692b55e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ebb6243-c33a-406a-9d81-72f3f1cc9cd0"));

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.UserId, x.PostId });
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "City", "Description", "Name" },
                values: new object[] { new Guid("cf6f2ea9-6a78-4d0d-a7bf-bd00ef67e374"), "Plovdiv", "In Plovdiv", "Ancient Theathre" });

            migrationBuilder.InsertData(
                table: "Excursions",
                columns: new[] { "Id", "CreationDate", "EndsOnDate", "Name", "Price", "StartsOnDate" },
                values: new object[] { new Guid("57ba3b75-3e64-45f6-a58e-75220c139eff"), new DateTime(2022, 4, 18, 21, 48, 57, 690, DateTimeKind.Local).AddTicks(5556), new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), "Plovdiv", 14m, new DateTime(2022, 4, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "Email", "Firstname", "Lastname", "PasswordHash", "Role", "Username" },
                values: new object[] { new Guid("4ec90d27-6a1f-43b5-bbbf-c22f52d7e381"), new DateTime(2022, 4, 18, 21, 48, 56, 968, DateTimeKind.Local).AddTicks(6047), "admin@gmail.com", "Ad", "min", "$2a$11$RWyB6Jg/7aayKoY9.MipOeYYvg9ol7Ro3RtBe5aVFooFWvtlA7Frm", 0, "Admin" });
        }
    }
}

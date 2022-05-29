using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e5d9c703-e3d4-49f6-8835-ede2a7a035fc"),
                column: "ConcurrencyStamp",
                value: "4e638d31-4f26-486a-aa97-7f021cc86974");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f9246e52-297e-4d04-964f-cc930e93947a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f01580d4-bbf8-4258-b2ef-0fe4dcf97f72", "AQAAAAEAACcQAAAAEIzpYyTDv638i2yt1gQSXjCN92GLEJt7PuaWDdwK/x7KQb2AwwvLbKK12xOvFk9XrA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 29, 9, 51, 4, 402, DateTimeKind.Local).AddTicks(2067));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e5d9c703-e3d4-49f6-8835-ede2a7a035fc"),
                column: "ConcurrencyStamp",
                value: "de80e4e4-09bb-4bcd-8da3-88ae950269bd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f9246e52-297e-4d04-964f-cc930e93947a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "41cae5a0-e70e-44a6-ba7b-37492924312a", "AQAAAAEAACcQAAAAEGXIU9JfAHf23nMgkvX4HiChnWe6quQei39DmaM06hgUsCjtybj2NVIfGk/47uvBkA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 28, 11, 3, 2, 146, DateTimeKind.Local).AddTicks(8561));
        }
    }
}

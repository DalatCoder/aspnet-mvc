using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 27, 21, 46, 50, 406, DateTimeKind.Local).AddTicks(7437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 27, 21, 36, 47, 37, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("e5d9c703-e3d4-49f6-8835-ede2a7a035fc"), "edf513e7-c7b7-405e-8b67-579a61779f04", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("e5d9c703-e3d4-49f6-8835-ede2a7a035fc"), new Guid("f9246e52-297e-4d04-964f-cc930e93947a") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("f9246e52-297e-4d04-964f-cc930e93947a"), 0, "fbf1a54f-46eb-4f95-88f2-eb89e7dbed66", new DateTime(2000, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "hieuntctk42@gmail.com", true, "Hieu", "Nguyen Trong", false, null, "hieuntctk42@gmail.com", "admin", "AQAAAAEAACcQAAAAEAK3kRgXj6KDzcVenyiE2x78CVtXBlzsalDVcWKaYMVupvSG84kYqeJB3/XXvP4pEg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 21, 46, 50, 426, DateTimeKind.Local).AddTicks(3515));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("e5d9c703-e3d4-49f6-8835-ede2a7a035fc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e5d9c703-e3d4-49f6-8835-ede2a7a035fc"), new Guid("f9246e52-297e-4d04-964f-cc930e93947a") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("f9246e52-297e-4d04-964f-cc930e93947a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 27, 21, 36, 47, 37, DateTimeKind.Local).AddTicks(5192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 27, 21, 46, 50, 406, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 5, 27, 21, 36, 47, 56, DateTimeKind.Local).AddTicks(2625));
        }
    }
}

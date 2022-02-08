using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class addProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0a47003c-2540-49ea-83ed-6151b529304e"),
                column: "ConcurrencyStamp",
                value: "61d3116b-1949-403d-a057-ed6727da9837");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1b1be361-8e76-4ca8-bb34-9dffd9c74780"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d55402ae-86cd-4655-ac7f-e981ca3c3aaf", "AQAAAAEAACcQAAAAEDPCZLzRS8wyugYRHRHoC4E0NcxGhtd/jirDLLneL00eU+4g1jpW4qmydrZm7QvQ9A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 8, 15, 7, 34, 247, DateTimeKind.Local).AddTicks(1924));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("0a47003c-2540-49ea-83ed-6151b529304e"),
                column: "ConcurrencyStamp",
                value: "a3d26ab1-44f8-4f25-bebc-5ddf589da21f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("1b1be361-8e76-4ca8-bb34-9dffd9c74780"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e516b4b-e291-40c9-b5a4-54ee94d11b41", "AQAAAAEAACcQAAAAEGtajiXjUy99F0UtrGNjsiJ8RqKg/aFHAJWRGNoFdlFdeHtsq2sxFmhRlILPtDHJuA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 6, 18, 8, 9, 749, DateTimeKind.Local).AddTicks(453));
        }
    }
}

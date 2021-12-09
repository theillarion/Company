using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company.Migrations
{
    public partial class _091220211720 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a11344dd-aed2-4a7b-8a76-073ab977b59f",
                column: "ConcurrencyStamp",
                value: "428fa1ec-cf91-4396-be59-5d170bce5442");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0eb497a3-24a1-4fb4-8948-6b922e756bf2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "05747b6b-2bd8-458d-a30f-8ce12c5d66bd", "AQAAAAEAACcQAAAAEDhsosNdvLtaEgr/6ovujbNo4yE41lfDAHacRD5OYTpLbCsja5gq5GKWdw2F6nMnKQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("1a9b3f54-d442-4e8f-afd9-80a704764fb9"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 17, 20, 16, 362, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("7af6dc8c-199b-4173-b311-16e65e588bd9"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 9, 17, 20, 16, 363, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("cb5d6de2-9b95-4432-be1d-d1e8a689111c"),
                columns: new[] { "CodeWord", "DateAdded" },
                values: new object[] { "PageContacts", new DateTime(2021, 12, 9, 17, 20, 16, 363, DateTimeKind.Local).AddTicks(3761) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a11344dd-aed2-4a7b-8a76-073ab977b59f",
                column: "ConcurrencyStamp",
                value: "0da1bbe8-e967-4856-8067-593c04a5a8e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0eb497a3-24a1-4fb4-8948-6b922e756bf2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d91f6b0-91b9-4c71-acb9-527f1a304540", "AQAAAAEAACcQAAAAECPLlodrU4Og8R6Hk5+mtlCKJGr5bLJ5b+g6IjBzaXBHtS3jH9JrePjtzvAfzGMSeQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("1a9b3f54-d442-4e8f-afd9-80a704764fb9"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 5, 19, 15, 17, 794, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("7af6dc8c-199b-4173-b311-16e65e588bd9"),
                column: "DateAdded",
                value: new DateTime(2021, 12, 5, 19, 15, 17, 795, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("cb5d6de2-9b95-4432-be1d-d1e8a689111c"),
                columns: new[] { "CodeWord", "DateAdded" },
                values: new object[] { "PageContact", new DateTime(2021, 12, 5, 19, 15, 17, 795, DateTimeKind.Local).AddTicks(3529) });
        }
    }
}

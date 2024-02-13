using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternetStore.Migrations
{
    public partial class _firstworking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "ProductItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a3f0009-3602-4548-8bcb-4ff4e8420830",
                column: "ConcurrencyStamp",
                value: "8ed895df-c0da-468d-873a-669ed9dff439");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "762b0a0d-c46d-4670-abc8-a5c5029b3ec7",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "dd962be5-0000-47c8-9e99-d6cfff22832d", "vegfruit23@gmail.com", "VEGFRUIT23@GMAIL.COM", "AQAAAAEAACcQAAAAEKUixaE9gi2y+6Bc7CPSVotYZUC1X0lbman7PtyPg0Ogvia9ulntbZ5TIk+I1wRe8Q==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3ebd4da3-48f7-4f17-a876-b800a51d7930"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 9, 15, 44, 40, 208, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5225d362-5d1c-4ff8-bf4d-e1cd82f91192"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 9, 15, 44, 40, 208, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("e3104e57-225b-473a-a8fc-8275b7cd662d"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 9, 15, 44, 40, 208, DateTimeKind.Utc).AddTicks(9173));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProductItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a3f0009-3602-4548-8bcb-4ff4e8420830",
                column: "ConcurrencyStamp",
                value: "c8343842-bf47-45f8-a7bb-648416fe8267");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "762b0a0d-c46d-4670-abc8-a5c5029b3ec7",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "8a0f2986-8927-4580-bbc3-a8290701db48", "myemail@gmail.com", "MYEMAIL@GMAIL.COM", "AQAAAAEAACcQAAAAEHleQUIPtq2a5Zvmws9D99idrlXUuU58Sy+fIZ4mg0LSmBXv/9C89DQnTyLlWDP0RA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3ebd4da3-48f7-4f17-a876-b800a51d7930"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 5, 12, 42, 35, 623, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("5225d362-5d1c-4ff8-bf4d-e1cd82f91192"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 5, 12, 42, 35, 623, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("e3104e57-225b-473a-a8fc-8275b7cd662d"),
                column: "DateAdded",
                value: new DateTime(2024, 2, 5, 12, 42, 35, 623, DateTimeKind.Utc).AddTicks(3376));
        }
    }
}

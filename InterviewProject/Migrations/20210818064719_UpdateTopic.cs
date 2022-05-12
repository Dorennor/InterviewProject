using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace InterviewProject.Migrations
{
    public partial class UpdateTopic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Topics",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a063d567-7af0-4db0-ab52-7737a999dcf5",
                column: "ConcurrencyStamp",
                value: "1bebf573-78d5-4082-8ed2-6c8d7be1b2ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9ed444-104b-4f39-a1fb-da6f02682970",
                column: "ConcurrencyStamp",
                value: "411fa638-87f9-4434-b36e-ad8671f1b16a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e34e058-e269-4597-8a7e-92b83a45a954",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88faf1a5-f4fe-4173-8224-400ab7d51696", "AQAAAAEAACcQAAAAEAlgeuVJ0h3wNwYva8GZ3NPx92enEqyM1/O9tzxEO7n6DGhSv4Q7AoRKUwVLDjf75A==", "b8c0588c-ffec-48b9-8b7d-ca21e699310b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47eec18f-75d3-4647-855c-b68170940b45", "AQAAAAEAACcQAAAAENujNSOQA1pHfDdUm8ZZ7N39/g6i8ZOB2BDT2Q1xwGrt0XBRH6sPupcyFnzqs7I9ng==", "1375807a-e51f-48bb-848a-512da748cf16" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDateTime",
                value: new DateTime(2021, 8, 18, 9, 47, 18, 297, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDateTime",
                value: new DateTime(2021, 8, 18, 9, 47, 18, 297, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastPostDateTime",
                value: new DateTime(2021, 8, 18, 9, 47, 18, 294, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastPostDateTime",
                value: new DateTime(2021, 8, 18, 9, 47, 18, 297, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.CreateIndex(
                name: "IX_Topics_Title",
                table: "Topics",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Topics_Title",
                table: "Topics");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a063d567-7af0-4db0-ab52-7737a999dcf5",
                column: "ConcurrencyStamp",
                value: "d9e07356-5bc2-48ea-b398-feac0202550b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9ed444-104b-4f39-a1fb-da6f02682970",
                column: "ConcurrencyStamp",
                value: "2cf9408d-2995-4730-9823-482090fe54ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e34e058-e269-4597-8a7e-92b83a45a954",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5158baee-3174-4e21-99d6-5b75b5221afc", "AQAAAAEAACcQAAAAEOi1IK0LOq5qnfmTL6+F1hvv5EdZk+D1dV9hJNLjiCkbB34Wbd04afaYapJ+5zkYJw==", "de563d71-5926-4adb-994f-20ee3372f876" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4de2d86-4f86-46d5-bad0-8087e196ed86", "AQAAAAEAACcQAAAAEGzSnHTVFFgyiAQCndQdMsOCH43Fik3oqSWbqm4CerGOOt0VLzaoB3iUKy0YMNJZVg==", "df6b329b-be3b-4c7e-88dc-4c03038ece8e" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDateTime",
                value: new DateTime(2021, 8, 18, 7, 41, 3, 644, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDateTime",
                value: new DateTime(2021, 8, 18, 7, 41, 3, 644, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastPostDateTime",
                value: new DateTime(2021, 8, 18, 7, 41, 3, 639, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastPostDateTime",
                value: new DateTime(2021, 8, 18, 7, 41, 3, 643, DateTimeKind.Local).AddTicks(9227));
        }
    }
}
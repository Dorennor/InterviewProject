using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace InterviewProject.Migrations
{
    public partial class Foreign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Topics",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a063d567-7af0-4db0-ab52-7737a999dcf5",
                column: "ConcurrencyStamp",
                value: "d7c1a20d-5f26-45dd-b129-e0395e78d652");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9ed444-104b-4f39-a1fb-da6f02682970",
                column: "ConcurrencyStamp",
                value: "4d7a489b-05ea-41ed-8e19-92699857e924");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e34e058-e269-4597-8a7e-92b83a45a954",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c86af3c4-1c18-42cb-8597-594cc734aefd", "AQAAAAEAACcQAAAAEHDw4FWX/R4bg5aS75i0hIqc66QVAEcWcNCSz8cclFQhIcSOF74pjT7nLC20Q3lpNw==", "7eace512-a612-46b8-b321-fe86e21bde6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa8a16f4-2e39-432f-bb66-38a49f1e9810", "AQAAAAEAACcQAAAAEGtA2y0SUy9Jp185xTaTRMrddzOw1MKgDYFagDdzHH7hM9ViRUxC5z0sv2B7/MYbFA==", "6ea7959d-8c6f-4fa1-8586-a7b69e6a846a" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDateTime",
                value: new DateTime(2021, 8, 18, 13, 57, 17, 421, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDateTime",
                value: new DateTime(2021, 8, 18, 13, 57, 17, 421, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastPostDateTime",
                value: new DateTime(2021, 8, 18, 13, 57, 17, 417, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastPostDateTime",
                value: new DateTime(2021, 8, 18, 13, 57, 17, 420, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.CreateIndex(
                name: "IX_Topics_UserId",
                table: "Topics",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TopicId",
                table: "Posts",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_AspNetUsers_UserId",
                table: "Topics",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_AspNetUsers_UserId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_UserId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TopicId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Topics");

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
    }
}
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace InterviewProject.Migrations
{
    public partial class UpdateForeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a063d567-7af0-4db0-ab52-7737a999dcf5",
                column: "ConcurrencyStamp",
                value: "5dab25a7-ff90-4203-8298-c26f16f1d6da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9ed444-104b-4f39-a1fb-da6f02682970",
                column: "ConcurrencyStamp",
                value: "88d3ce4e-6334-4845-a0b0-feae3c7dd49e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e34e058-e269-4597-8a7e-92b83a45a954",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a4760d5-a191-4134-84d2-64831ec10ff8", "AQAAAAEAACcQAAAAEPLh5Fu60N40Gtq2gZwzp1baVQU/Hmh5c8DbijQao3/rn5WmT16Fo5MeBTJyyUkIQQ==", "23f4de14-f01b-408d-bc84-132bbcbceda1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "961a9fa0-1eee-4cc3-a71a-c20e58d95d4e", "AQAAAAEAACcQAAAAEHrKwxrk5BgZ/X9uHjZM5DwcdvuT0soWkUVfxcg3Bu5asFjwWmoLxG0aje8yi2vl9g==", "c33a3148-02b3-4fc5-a50b-2734a53d4c56" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDateTime",
                value: new DateTime(2021, 8, 18, 14, 4, 48, 876, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDateTime",
                value: new DateTime(2021, 8, 18, 14, 4, 48, 876, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastPostDateTime", "UserId" },
                values: new object[] { new DateTime(2021, 8, 18, 14, 4, 48, 873, DateTimeKind.Local).AddTicks(1343), "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastPostDateTime", "UserId" },
                values: new object[] { new DateTime(2021, 8, 18, 14, 4, 48, 876, DateTimeKind.Local).AddTicks(544), "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "LastPostDateTime", "UserId" },
                values: new object[] { new DateTime(2021, 8, 18, 13, 57, 17, 417, DateTimeKind.Local).AddTicks(3112), null });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastPostDateTime", "UserId" },
                values: new object[] { new DateTime(2021, 8, 18, 13, 57, 17, 420, DateTimeKind.Local).AddTicks(6866), null });
        }
    }
}
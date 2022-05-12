using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace InterviewProject.Migrations
{
    public partial class UpdateTopicPostClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Topics",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Posts",
                newName: "UserName");

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
                columns: new[] { "PostDateTime", "UserName" },
                values: new object[] { new DateTime(2021, 8, 18, 7, 41, 3, 644, DateTimeKind.Local).AddTicks(4909), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PostDateTime", "UserName" },
                values: new object[] { new DateTime(2021, 8, 18, 7, 41, 3, 644, DateTimeKind.Local).AddTicks(6938), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastPostDateTime", "UserName" },
                values: new object[] { new DateTime(2021, 8, 18, 7, 41, 3, 639, DateTimeKind.Local).AddTicks(4564), "Administrator" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastPostDateTime", "UserName" },
                values: new object[] { new DateTime(2021, 8, 18, 7, 41, 3, 643, DateTimeKind.Local).AddTicks(9227), "Administrator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Topics",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Posts",
                newName: "UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a063d567-7af0-4db0-ab52-7737a999dcf5",
                column: "ConcurrencyStamp",
                value: "8e3aaf76-af4d-4263-ac73-0ec2d2f31052");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb9ed444-104b-4f39-a1fb-da6f02682970",
                column: "ConcurrencyStamp",
                value: "b45d0105-ebc7-484b-b8d0-aeaff58beafc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e34e058-e269-4597-8a7e-92b83a45a954",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b34aa12-cc6c-49ab-bb61-494390ca0e5c", "AQAAAAEAACcQAAAAEN5oqvWfAzGQ1TDX9JWdE0xx9vxZQ7KJLDjH3JOxvlOyPHeXkvXZEs1XGhAN1KnDVw==", "27e09402-5fc2-46c7-a428-56caaea1ebed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4846e4ab-4e09-41c3-90c3-480aaf709a4e", "AQAAAAEAACcQAAAAEMEsOjj0K/yVIBvzgtnknI6QK5NZJ87SYpKG8SMvQEsYTma6jZd8UxIvFCQi50V08w==", "ec9a47d6-8744-4582-8ea9-de7d83692690" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PostDateTime", "UserId" },
                values: new object[] { new DateTime(2021, 8, 18, 6, 11, 25, 853, DateTimeKind.Local).AddTicks(2452), "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PostDateTime", "UserId" },
                values: new object[] { new DateTime(2021, 8, 18, 6, 11, 25, 853, DateTimeKind.Local).AddTicks(3566), "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastPostDateTime", "UserId" },
                values: new object[] { new DateTime(2021, 8, 18, 6, 11, 25, 850, DateTimeKind.Local).AddTicks(573), "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastPostDateTime", "UserId" },
                values: new object[] { new DateTime(2021, 8, 18, 6, 11, 25, 852, DateTimeKind.Local).AddTicks(9320), "a8dcb9d5-5d82-427f-b37c-b808c7ebe9af" });
        }
    }
}
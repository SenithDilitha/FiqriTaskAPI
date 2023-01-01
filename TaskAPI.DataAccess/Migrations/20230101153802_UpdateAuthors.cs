using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class UpdateAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 1, 1, 21, 8, 2, 252, DateTimeKind.Local).AddTicks(6819), new DateTime(2023, 1, 3, 21, 8, 2, 253, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 1, 1, 21, 8, 2, 253, DateTimeKind.Local).AddTicks(6880), new DateTime(2023, 1, 6, 21, 8, 2, 253, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 1, 1, 21, 8, 2, 253, DateTimeKind.Local).AddTicks(6891), new DateTime(2023, 1, 4, 21, 8, 2, 253, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 12, 29, 17, 19, 17, 895, DateTimeKind.Local).AddTicks(1440), new DateTime(2022, 12, 31, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 12, 29, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(3762), new DateTime(2023, 1, 3, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2022, 12, 29, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(3773), new DateTime(2023, 1, 1, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

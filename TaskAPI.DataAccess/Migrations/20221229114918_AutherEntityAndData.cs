using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class AutherEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Senith" },
                    { 2, "Dilitha" },
                    { 3, "Sumashi" },
                    { 4, "Hansani" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Created", "Description", "Due", "Title" },
                values: new object[] { 3, new DateTime(2022, 12, 29, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(3773), "Purchase Camera from super market DB", new DateTime(2023, 1, 1, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(3774), "Purchase Camera from DB" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 2, new DateTime(2022, 12, 29, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(3762), "Need some groceries from super market DB", new DateTime(2023, 1, 3, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(3767), 0, "Need some groceries from DB" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, 1, new DateTime(2022, 12, 29, 17, 19, 17, 895, DateTimeKind.Local).AddTicks(1440), "Get some text books for school DB", new DateTime(2022, 12, 31, 17, 19, 17, 897, DateTimeKind.Local).AddTicks(2920), 0, "Get books for school from DB" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Author_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Description", "Due", "Title" },
                values: new object[] { new DateTime(2022, 3, 7, 14, 28, 19, 129, DateTimeKind.Local).AddTicks(2163), "Get some text books for school DB", new DateTime(2022, 3, 9, 14, 28, 19, 129, DateTimeKind.Local).AddTicks(8863), "Get books for school from DB" });
        }
    }
}

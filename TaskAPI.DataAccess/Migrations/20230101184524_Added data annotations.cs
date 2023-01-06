using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class Addeddataannotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AddressNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    street = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    city = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Due = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todos_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AddressNo", "FullName", "city", "street" },
                values: new object[,]
                {
                    { 1, "1", "Senith", "Colombo 1", "Street 1" },
                    { 2, "2", "Dilitha", "Colombo 2", "Street 2" },
                    { 3, "3", "Sumashi", "Colombo 3", "Street 3" },
                    { 4, "4", "Hansani", "Colombo 4", "Street 4" }
                });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, 1, new DateTime(2023, 1, 2, 0, 15, 23, 714, DateTimeKind.Local).AddTicks(6601), "Get some text books for school DB", new DateTime(2023, 1, 4, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3129), 0, "Get books for school from DB" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 2, new DateTime(2023, 1, 2, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3738), "Need some groceries from super market DB", new DateTime(2023, 1, 7, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3741), 0, "Need some groceries from DB" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 3, new DateTime(2023, 1, 2, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3746), "Purchase Camera from super market DB", new DateTime(2023, 1, 5, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3747), 0, "Purchase Camera from DB" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}

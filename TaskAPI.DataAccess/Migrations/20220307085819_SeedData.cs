using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, new DateTime(2022, 3, 7, 14, 28, 19, 129, DateTimeKind.Local).AddTicks(2163), "Get some text books for school DB", new DateTime(2022, 3, 9, 14, 28, 19, 129, DateTimeKind.Local).AddTicks(8863), 0, "Get books for school from DB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

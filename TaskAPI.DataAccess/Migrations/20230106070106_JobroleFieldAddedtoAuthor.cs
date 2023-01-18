using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DataAccess.Migrations
{
    public partial class JobroleFieldAddedtoAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "street",
                table: "Authors",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Authors",
                newName: "City");

            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "System Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 1, 6, 12, 31, 5, 928, DateTimeKind.Local).AddTicks(8878), new DateTime(2023, 1, 8, 12, 31, 5, 930, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 1, 6, 12, 31, 5, 930, DateTimeKind.Local).AddTicks(9988), new DateTime(2023, 1, 11, 12, 31, 5, 930, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 1, 6, 12, 31, 5, 931, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 1, 9, 12, 31, 5, 931, DateTimeKind.Local).AddTicks(35) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Authors",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Authors",
                newName: "city");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 15, 23, 714, DateTimeKind.Local).AddTicks(6601), new DateTime(2023, 1, 4, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3738), new DateTime(2023, 1, 7, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3746), new DateTime(2023, 1, 5, 0, 15, 23, 715, DateTimeKind.Local).AddTicks(3747) });
        }
    }
}

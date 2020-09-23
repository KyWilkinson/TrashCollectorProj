using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class balanceadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5eb49437-74a5-4a27-a58b-e82b691e12eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70459925-c6af-4788-a251-85b69ae6ed07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d77b8e17-18c0-4312-a737-56293b55fd38");

            migrationBuilder.AddColumn<double>(
                name: "balance",
                table: "Customer",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "oneDayPickup",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1f37af9-09b5-4d5c-a6f2-167166444e66", "96eda666-b47a-429f-a8fc-7e7bcfa50e38", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b670fb3d-d1e2-450a-86f9-d31b1fb0a512", "feb206a9-4248-4e23-8413-390ecf9a16c9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3604d97f-1835-4aec-860f-15b3ba1d028e", "665ce007-0fd1-4b92-ab24-e7f15bae746e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3604d97f-1835-4aec-860f-15b3ba1d028e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b670fb3d-d1e2-450a-86f9-d31b1fb0a512");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1f37af9-09b5-4d5c-a6f2-167166444e66");

            migrationBuilder.DropColumn(
                name: "balance",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "oneDayPickup",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70459925-c6af-4788-a251-85b69ae6ed07", "9f8ad44d-06e9-4e3f-8d50-9420f2893639", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d77b8e17-18c0-4312-a737-56293b55fd38", "df61ffa0-6841-4ae4-9ec1-8accde91152e", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5eb49437-74a5-4a27-a58b-e82b691e12eb", "941b8b41-5776-4f22-974a-3bc5d5053be8", "Employee", "EMPLOYEE" });
        }
    }
}

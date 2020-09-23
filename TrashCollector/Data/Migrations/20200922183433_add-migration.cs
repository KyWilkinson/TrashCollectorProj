using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class addmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2da2811c-5eab-4459-a48d-5ba0d8c8d932");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a224ef15-4fee-4fec-aef4-0f02f60fb2d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de2156b8-4737-44c9-8917-fa10d83a28fe");

            migrationBuilder.AddColumn<string>(
                name: "pickUpDay",
                table: "Customer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    employeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zipCode = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.employeeId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

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

            migrationBuilder.DropColumn(
                name: "pickUpDay",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2da2811c-5eab-4459-a48d-5ba0d8c8d932", "c0e814c7-cd98-4c0f-ba0e-9bee8fce55bd", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de2156b8-4737-44c9-8917-fa10d83a28fe", "5c4fc315-358a-4dea-9835-bdd1e005495a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a224ef15-4fee-4fec-aef4-0f02f60fb2d0", "e12d452f-9752-4120-8cea-21bbd3f24d27", "Employee", "EMPLOYEE" });
        }
    }
}

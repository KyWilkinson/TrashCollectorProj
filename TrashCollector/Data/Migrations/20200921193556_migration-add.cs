using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class migrationadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f53a3a5-7144-4753-a72d-a873259ffae5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bedb932c-b037-47ce-9650-fb37cabcedb7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfe8735e-c178-4892-9a0f-caac589b763a");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f53a3a5-7144-4753-a72d-a873259ffae5", "a18c49df-975e-4c10-af8f-8a95e4245742", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dfe8735e-c178-4892-9a0f-caac589b763a", "8eca541d-d5be-4f09-9d05-f03f6333f016", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bedb932c-b037-47ce-9650-fb37cabcedb7", "816c73eb-466e-434d-aba8-52d3257105dc", "Employee", "EMPLOYEE" });
        }
    }
}

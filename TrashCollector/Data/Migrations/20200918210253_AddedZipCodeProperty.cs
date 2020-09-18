using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class AddedZipCodeProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6dc0717a-bce2-4d2f-89eb-e702bf6a4365");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1197fa9-0f46-4285-943e-9898200a75ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5dead34-f577-44a8-832a-95f76bc129a9");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Customer",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5dead34-f577-44a8-832a-95f76bc129a9", "62da427d-2911-4454-a252-3b4dbde13119", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b1197fa9-0f46-4285-943e-9898200a75ee", "e09b3a1d-4e06-4962-8c2d-c02cdb4d816b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6dc0717a-bce2-4d2f-89eb-e702bf6a4365", "7962ef85-4c38-4379-9ff7-11ee711f802c", "Employee", "EMPLOYEE" });
        }
    }
}

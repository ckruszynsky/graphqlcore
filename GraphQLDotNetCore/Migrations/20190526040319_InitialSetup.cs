using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQLDotNetCore.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4855d973-eb70-48f1-a619-a2d62ce124d3"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c810d02e-5235-45ff-80b4-34bca427479f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cb9ffd28-1fb2-4ce9-9f39-497bdf8a5096"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("514c3bc3-14df-4515-bc13-256e75dd2e9f"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("791716be-7eff-4370-814e-3884d27ae682"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("69ca07a7-f07b-459e-9390-ec4fe5b9b284"), "John Doe's address", "John Doe" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("69ebe912-61dc-4caf-95fc-765ec5e3ef72"), "Jane Doe's address", "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("4f54c953-fdcf-46fb-a54c-92d09f0fd110"), "Cash account for our users", new Guid("69ca07a7-f07b-459e-9390-ec4fe5b9b284"), 0 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("34bc7191-5622-466a-9373-2a9f7486c9ec"), "Savings account for our users", new Guid("69ebe912-61dc-4caf-95fc-765ec5e3ef72"), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("20bff8ae-2620-48ca-a2bb-bc71fd4235af"), "Income account for our users", new Guid("69ebe912-61dc-4caf-95fc-765ec5e3ef72"), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("20bff8ae-2620-48ca-a2bb-bc71fd4235af"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("34bc7191-5622-466a-9373-2a9f7486c9ec"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4f54c953-fdcf-46fb-a54c-92d09f0fd110"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("69ca07a7-f07b-459e-9390-ec4fe5b9b284"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("69ebe912-61dc-4caf-95fc-765ec5e3ef72"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("514c3bc3-14df-4515-bc13-256e75dd2e9f"), "John Doe's address", "John Doe" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("791716be-7eff-4370-814e-3884d27ae682"), "Jane Doe's address", "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("cb9ffd28-1fb2-4ce9-9f39-497bdf8a5096"), "Cash account for our users", new Guid("514c3bc3-14df-4515-bc13-256e75dd2e9f"), 0 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("4855d973-eb70-48f1-a619-a2d62ce124d3"), "Savings account for our users", new Guid("791716be-7eff-4370-814e-3884d27ae682"), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("c810d02e-5235-45ff-80b4-34bca427479f"), "Income account for our users", new Guid("791716be-7eff-4370-814e-3884d27ae682"), 3 });
        }
    }
}

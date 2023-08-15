using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("6bd7c1c8-66be-455d-813f-a7645e1e913a"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("7b00c998-a15e-400d-8ead-c98fafbb5059"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("80f4362b-f32f-46d5-bf10-84c23beed4c7"));

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: new Guid("8e91f1cb-7618-4be1-aa0e-35610bceac96"));

            migrationBuilder.InsertData(
                table: "DeliveryPoint",
                columns: new[] { "Id", "CreatedAt", "DeliveryPointName", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("67468fcc-5501-4f59-87c4-21ef9e7be666"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Distribution Center", null, 2 },
                    { new Guid("9a170367-8cb6-4a6d-b5b5-7dabaeff4429"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Transfer Center", null, 3 },
                    { new Guid("e06fc491-0f44-4404-a200-8da36c29ef60"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Branch", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "CreatedAt", "Plate", "UpdatedAt" },
                values: new object[] { new Guid("949234b5-ebf8-4428-a9b7-b0576bb78d6c"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "34 TR 321", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("67468fcc-5501-4f59-87c4-21ef9e7be666"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("9a170367-8cb6-4a6d-b5b5-7dabaeff4429"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("e06fc491-0f44-4404-a200-8da36c29ef60"));

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: new Guid("949234b5-ebf8-4428-a9b7-b0576bb78d6c"));

            migrationBuilder.InsertData(
                table: "DeliveryPoint",
                columns: new[] { "Id", "CreatedAt", "DeliveryPointName", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("6bd7c1c8-66be-455d-813f-a7645e1e913a"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Distribution Center", null, 2 },
                    { new Guid("7b00c998-a15e-400d-8ead-c98fafbb5059"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Transfer Center", null, 3 },
                    { new Guid("80f4362b-f32f-46d5-bf10-84c23beed4c7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Branch", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "CreatedAt", "Plate", "UpdatedAt" },
                values: new object[] { new Guid("8e91f1cb-7618-4be1-aa0e-35610bceac96"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "34 TR 321", null });
        }
    }
}

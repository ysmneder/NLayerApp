using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Repository.Migrations
{
    /// <inheritdoc />
    public partial class removeDeliveryPointUnloadingfieldfromShipmentBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BagStatus",
                keyColumn: "Id",
                keyValue: new Guid("5604be57-168d-4969-ae33-a17779777da3"));

            migrationBuilder.DeleteData(
                table: "BagStatus",
                keyColumn: "Id",
                keyValue: new Guid("88514587-e546-4792-8c4b-ab4078ed1045"));

            migrationBuilder.DeleteData(
                table: "BagStatus",
                keyColumn: "Id",
                keyValue: new Guid("b28a98aa-18bd-4abc-941d-3456cf18db0f"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("2258d01f-1bd5-4e06-a4f7-9bc211271736"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("580bdafc-3bd6-4c6f-b9b4-0583736ec935"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("f62bc1dd-0ff0-4c58-8312-71a43d83881f"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("25ac85c0-3ce0-4f61-b794-fe89f02d77e7"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("5a4c0117-f363-43e9-9c31-633b9f506e98"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("6a493c9d-a67d-4f24-9278-92681a203515"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("a700856b-1df0-4acd-9fd9-00ea982f9760"));

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: new Guid("3d6752b5-36b7-42a6-90c9-23a2830a0b38"));

            migrationBuilder.DropColumn(
                name: "DeliveryPointUnloading",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "DeliveryPointUnloading",
                table: "Bag");

            migrationBuilder.InsertData(
                table: "BagStatus",
                columns: new[] { "Id", "CreatedAt", "Status", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("5c9d1ec5-0f69-46aa-9245-52d2c5ec7d8e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Unloaded", null, 3 },
                    { new Guid("797f1aee-89d0-475d-bb60-f68e399eda93"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Loaded", null, 2 },
                    { new Guid("8457e93b-0383-42d6-86a3-e2fc96476d59"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Created", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "DeliveryPoint",
                columns: new[] { "Id", "CreatedAt", "DeliveryPointName", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("6585ed77-e248-4269-bea4-1919a1cdb498"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Distribution Center", null, 2 },
                    { new Guid("90f205d0-ac7e-44f0-b495-0a80edfbe3a1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Branch", null, 1 },
                    { new Guid("cc95ffec-932f-4ce2-ad6a-556e76a99f11"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Transfer Center", null, 3 }
                });

            migrationBuilder.InsertData(
                table: "PackageStatus",
                columns: new[] { "Id", "CreatedAt", "Status", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("3b1941d8-20b6-4185-b4b2-35163c3aa5b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Created", null, 1 },
                    { new Guid("6c34937a-32b6-4baa-a387-2d914c98c943"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Loaded into Bag", null, 2 },
                    { new Guid("bef3d5de-ee47-4ae4-b4c3-4bd789e95859"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Unloaded", null, 4 },
                    { new Guid("ddd56514-9170-4349-9c39-6259fd45a5df"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Loaded", null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "CreatedAt", "Plate", "UpdatedAt" },
                values: new object[] { new Guid("1bca34a6-dfcc-451d-a1b8-8b2a9bafaf43"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "34 TR 321", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BagStatus",
                keyColumn: "Id",
                keyValue: new Guid("5c9d1ec5-0f69-46aa-9245-52d2c5ec7d8e"));

            migrationBuilder.DeleteData(
                table: "BagStatus",
                keyColumn: "Id",
                keyValue: new Guid("797f1aee-89d0-475d-bb60-f68e399eda93"));

            migrationBuilder.DeleteData(
                table: "BagStatus",
                keyColumn: "Id",
                keyValue: new Guid("8457e93b-0383-42d6-86a3-e2fc96476d59"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("6585ed77-e248-4269-bea4-1919a1cdb498"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("90f205d0-ac7e-44f0-b495-0a80edfbe3a1"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("cc95ffec-932f-4ce2-ad6a-556e76a99f11"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("3b1941d8-20b6-4185-b4b2-35163c3aa5b1"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("6c34937a-32b6-4baa-a387-2d914c98c943"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("bef3d5de-ee47-4ae4-b4c3-4bd789e95859"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("ddd56514-9170-4349-9c39-6259fd45a5df"));

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: new Guid("1bca34a6-dfcc-451d-a1b8-8b2a9bafaf43"));

            migrationBuilder.AddColumn<int>(
                name: "DeliveryPointUnloading",
                table: "Package",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryPointUnloading",
                table: "Bag",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "BagStatus",
                columns: new[] { "Id", "CreatedAt", "Status", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("5604be57-168d-4969-ae33-a17779777da3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Loaded", null, 2 },
                    { new Guid("88514587-e546-4792-8c4b-ab4078ed1045"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Unloaded", null, 3 },
                    { new Guid("b28a98aa-18bd-4abc-941d-3456cf18db0f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Created", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "DeliveryPoint",
                columns: new[] { "Id", "CreatedAt", "DeliveryPointName", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("2258d01f-1bd5-4e06-a4f7-9bc211271736"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Transfer Center", null, 3 },
                    { new Guid("580bdafc-3bd6-4c6f-b9b4-0583736ec935"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Branch", null, 1 },
                    { new Guid("f62bc1dd-0ff0-4c58-8312-71a43d83881f"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Distribution Center", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "PackageStatus",
                columns: new[] { "Id", "CreatedAt", "Status", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("25ac85c0-3ce0-4f61-b794-fe89f02d77e7"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Loaded into Bag", null, 2 },
                    { new Guid("5a4c0117-f363-43e9-9c31-633b9f506e98"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Loaded", null, 3 },
                    { new Guid("6a493c9d-a67d-4f24-9278-92681a203515"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Created", null, 1 },
                    { new Guid("a700856b-1df0-4acd-9fd9-00ea982f9760"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Unloaded", null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "CreatedAt", "Plate", "UpdatedAt" },
                values: new object[] { new Guid("3d6752b5-36b7-42a6-90c9-23a2830a0b38"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "34 TR 321", null });
        }
    }
}

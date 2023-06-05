using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Repository.Migrations
{
    /// <inheritdoc />
    public partial class deliveryPointkey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BagStatus",
                keyColumn: "Id",
                keyValue: new Guid("6670922e-2851-4f86-b3b8-b3964604bfe6"));

            migrationBuilder.DeleteData(
                table: "BagStatus",
                keyColumn: "Id",
                keyValue: new Guid("7d8b40c3-7b56-43ff-9622-bde61387581b"));

            migrationBuilder.DeleteData(
                table: "BagStatus",
                keyColumn: "Id",
                keyValue: new Guid("ab548350-9319-47c3-9bd0-867d28f17f80"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("62a6d8a2-15f2-4f0f-a36b-728bc2a884b9"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("791ef4b8-76bc-4c7b-8b6f-55d7c3f5f95e"));

            migrationBuilder.DeleteData(
                table: "DeliveryPoint",
                keyColumn: "Id",
                keyValue: new Guid("972fea7b-e073-4247-9ba5-c5d6c2569e8d"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("4ee3b7bb-adef-41be-b6a4-82bc06aa0887"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("5d0b2feb-cabc-47ea-a8ed-157a99ab3ede"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("63287bf8-9720-441b-b683-8c634f90a5e3"));

            migrationBuilder.DeleteData(
                table: "PackageStatus",
                keyColumn: "Id",
                keyValue: new Guid("c87d70b4-a3d7-4023-9e78-a4efdc01156e"));

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: new Guid("266243eb-45ec-4503-ba28-37e73327e9b1"));

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryPointId",
                table: "Package",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryPointId",
                table: "Bag",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Package_DeliveryPointId",
                table: "Package",
                column: "DeliveryPointId");

            migrationBuilder.CreateIndex(
                name: "IX_Bag_DeliveryPointId",
                table: "Bag",
                column: "DeliveryPointId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bag_DeliveryPoint_DeliveryPointId",
                table: "Bag",
                column: "DeliveryPointId",
                principalTable: "DeliveryPoint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_DeliveryPoint_DeliveryPointId",
                table: "Package",
                column: "DeliveryPointId",
                principalTable: "DeliveryPoint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bag_DeliveryPoint_DeliveryPointId",
                table: "Bag");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_DeliveryPoint_DeliveryPointId",
                table: "Package");

            migrationBuilder.DropIndex(
                name: "IX_Package_DeliveryPointId",
                table: "Package");

            migrationBuilder.DropIndex(
                name: "IX_Bag_DeliveryPointId",
                table: "Bag");

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
                name: "DeliveryPointId",
                table: "Package");

            migrationBuilder.DropColumn(
                name: "DeliveryPointId",
                table: "Bag");

            migrationBuilder.InsertData(
                table: "BagStatus",
                columns: new[] { "Id", "CreatedAt", "Status", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("6670922e-2851-4f86-b3b8-b3964604bfe6"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Loaded", null, 2 },
                    { new Guid("7d8b40c3-7b56-43ff-9622-bde61387581b"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Unloaded", null, 3 },
                    { new Guid("ab548350-9319-47c3-9bd0-867d28f17f80"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Created", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "DeliveryPoint",
                columns: new[] { "Id", "CreatedAt", "DeliveryPointName", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("62a6d8a2-15f2-4f0f-a36b-728bc2a884b9"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Transfer Center", null, 3 },
                    { new Guid("791ef4b8-76bc-4c7b-8b6f-55d7c3f5f95e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Branch", null, 1 },
                    { new Guid("972fea7b-e073-4247-9ba5-c5d6c2569e8d"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Distribution Center", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "PackageStatus",
                columns: new[] { "Id", "CreatedAt", "Status", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("4ee3b7bb-adef-41be-b6a4-82bc06aa0887"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Created", null, 1 },
                    { new Guid("5d0b2feb-cabc-47ea-a8ed-157a99ab3ede"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Loaded", null, 3 },
                    { new Guid("63287bf8-9720-441b-b683-8c634f90a5e3"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Loaded into Bag", null, 2 },
                    { new Guid("c87d70b4-a3d7-4023-9e78-a4efdc01156e"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Unloaded", null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "CreatedAt", "Plate", "UpdatedAt" },
                values: new object[] { new Guid("266243eb-45ec-4503-ba28-37e73327e9b1"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "34 TR 321", null });
        }
    }
}

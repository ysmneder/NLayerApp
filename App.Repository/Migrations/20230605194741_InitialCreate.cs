using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Repository.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BagStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryPoint",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DeliveryPointName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPoint", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PackageStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Plate = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BagStatusId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    VolumetricWeight = table.Column<decimal>(type: "numeric", nullable: false),
                    DeliveryPointUnloading = table.Column<int>(type: "integer", nullable: false),
                    Barcode = table.Column<string>(type: "text", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bag_BagStatus_BagStatusId",
                        column: x => x.BagStatusId,
                        principalTable: "BagStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bag_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AssignedBagBarcode = table.Column<string>(type: "text", nullable: true),
                    PackageStatusId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    VolumetricWeight = table.Column<decimal>(type: "numeric", nullable: false),
                    DeliveryPointUnloading = table.Column<int>(type: "integer", nullable: false),
                    Barcode = table.Column<string>(type: "text", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Package_PackageStatus_PackageStatusId",
                        column: x => x.PackageStatusId,
                        principalTable: "PackageStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Package_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Bag_BagStatusId",
                table: "Bag",
                column: "BagStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bag_VehicleId",
                table: "Bag",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_PackageStatusId",
                table: "Package",
                column: "PackageStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_VehicleId",
                table: "Package",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bag");

            migrationBuilder.DropTable(
                name: "DeliveryPoint");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "BagStatus");

            migrationBuilder.DropTable(
                name: "PackageStatus");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}

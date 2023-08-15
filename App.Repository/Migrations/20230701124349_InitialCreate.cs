using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    Value = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagStatus", x => x.Value);
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
                    Value = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageStatus", x => x.Value);
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
                    BagStatusId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    VolumetricWeight = table.Column<decimal>(type: "numeric", nullable: false),
                    DeliveryPointId = table.Column<Guid>(type: "uuid", nullable: false),
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
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bag_DeliveryPoint_DeliveryPointId",
                        column: x => x.DeliveryPointId,
                        principalTable: "DeliveryPoint",
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
                    PackageStatusId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    VolumetricWeight = table.Column<decimal>(type: "numeric", nullable: false),
                    DeliveryPointId = table.Column<Guid>(type: "uuid", nullable: false),
                    Barcode = table.Column<string>(type: "text", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Package_DeliveryPoint_DeliveryPointId",
                        column: x => x.DeliveryPointId,
                        principalTable: "DeliveryPoint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Package_PackageStatus_PackageStatusId",
                        column: x => x.PackageStatusId,
                        principalTable: "PackageStatus",
                        principalColumn: "Value",
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
                columns: new[] { "Value", "CreatedAt", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loaded" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unloaded" }
                });

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
                table: "PackageStatus",
                columns: new[] { "Value", "CreatedAt", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Created" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loaded into Bag" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Loaded" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unloaded" }
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "CreatedAt", "Plate", "UpdatedAt" },
                values: new object[] { new Guid("8e91f1cb-7618-4be1-aa0e-35610bceac96"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "34 TR 321", null });

            migrationBuilder.CreateIndex(
                name: "IX_Bag_BagStatusId",
                table: "Bag",
                column: "BagStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bag_DeliveryPointId",
                table: "Bag",
                column: "DeliveryPointId");

            migrationBuilder.CreateIndex(
                name: "IX_Bag_VehicleId",
                table: "Bag",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Package_DeliveryPointId",
                table: "Package",
                column: "DeliveryPointId");

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
                name: "Package");

            migrationBuilder.DropTable(
                name: "BagStatus");

            migrationBuilder.DropTable(
                name: "DeliveryPoint");

            migrationBuilder.DropTable(
                name: "PackageStatus");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}

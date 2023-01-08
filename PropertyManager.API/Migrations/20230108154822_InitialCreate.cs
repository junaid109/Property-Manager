using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyManager.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropertyCondition",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCondition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyCooling",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyCooling", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyHeating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyHeating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyStatus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyStyle",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyStyle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRental = table.Column<bool>(type: "bit", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RentalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SquareFeet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bedrooms = table.Column<int>(type: "int", nullable: true),
                    Bathrooms = table.Column<int>(type: "int", nullable: true),
                    YearBuilt = table.Column<int>(type: "int", nullable: true),
                    YearRenovated = table.Column<int>(type: "int", nullable: true),
                    GarageSize = table.Column<int>(type: "int", nullable: true),
                    LotSize = table.Column<int>(type: "int", nullable: true),
                    Stories = table.Column<int>(type: "int", nullable: true),
                    ParkingSpaces = table.Column<int>(type: "int", nullable: true),
                    PoolSize = table.Column<int>(type: "int", nullable: true),
                    PropertyTypeId = table.Column<int>(type: "int", nullable: true),
                    PropertyTypeId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PropertyStatusId = table.Column<int>(type: "int", nullable: true),
                    PropertyStatusId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PropertyStyleId = table.Column<int>(type: "int", nullable: true),
                    PropertyStyleId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PropertyConditionId = table.Column<int>(type: "int", nullable: true),
                    PropertyConditionId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PropertyHeatingId = table.Column<int>(type: "int", nullable: true),
                    PropertyCoolingId = table.Column<int>(type: "int", nullable: true),
                    PropertyCoolingId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PropertyRoofId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Property_PropertyCondition_PropertyConditionId1",
                        column: x => x.PropertyConditionId1,
                        principalTable: "PropertyCondition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_PropertyCooling_PropertyCoolingId1",
                        column: x => x.PropertyCoolingId1,
                        principalTable: "PropertyCooling",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_PropertyHeating_PropertyHeatingId",
                        column: x => x.PropertyHeatingId,
                        principalTable: "PropertyHeating",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_PropertyStatus_PropertyStatusId1",
                        column: x => x.PropertyStatusId1,
                        principalTable: "PropertyStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_PropertyStyle_PropertyStyleId1",
                        column: x => x.PropertyStyleId1,
                        principalTable: "PropertyStyle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Property_PropertyType_PropertyTypeId1",
                        column: x => x.PropertyTypeId1,
                        principalTable: "PropertyType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyConditionId1",
                table: "Property",
                column: "PropertyConditionId1");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyCoolingId1",
                table: "Property",
                column: "PropertyCoolingId1");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyHeatingId",
                table: "Property",
                column: "PropertyHeatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyStatusId1",
                table: "Property",
                column: "PropertyStatusId1");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyStyleId1",
                table: "Property",
                column: "PropertyStyleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropertyTypeId1",
                table: "Property",
                column: "PropertyTypeId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "PropertyCondition");

            migrationBuilder.DropTable(
                name: "PropertyCooling");

            migrationBuilder.DropTable(
                name: "PropertyHeating");

            migrationBuilder.DropTable(
                name: "PropertyStatus");

            migrationBuilder.DropTable(
                name: "PropertyStyle");

            migrationBuilder.DropTable(
                name: "PropertyType");
        }
    }
}

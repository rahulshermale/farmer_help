using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmerDotNet.Migrations
{
    /// <inheritdoc />
    public partial class farm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Farmers",
                columns: table => new
                {
                    FarmerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FMoNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmers", x => x.FarmerId);
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    MarketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MContact = table.Column<int>(type: "int", nullable: true),
                    MCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.MarketId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    BuyerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.BuyerId);
                    table.ForeignKey(
                        name: "FK_Employees_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId");
                });

            migrationBuilder.CreateTable(
                name: "FarmerMarket",
                columns: table => new
                {
                    MarketsFarmerId = table.Column<int>(type: "int", nullable: false),
                    MarketsMarketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmerMarket", x => new { x.MarketsFarmerId, x.MarketsMarketId });
                    table.ForeignKey(
                        name: "FK_FarmerMarket_Farmers_MarketsFarmerId",
                        column: x => x.MarketsFarmerId,
                        principalTable: "Farmers",
                        principalColumn: "FarmerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FarmerMarket_Markets_MarketsMarketId",
                        column: x => x.MarketsMarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicals",
                columns: table => new
                {
                    VehicalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FarmerId = table.Column<int>(type: "int", nullable: true),
                    MarketId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicals", x => x.VehicalId);
                    table.ForeignKey(
                        name: "FK_Vehicals_Farmers_FarmerId",
                        column: x => x.FarmerId,
                        principalTable: "Farmers",
                        principalColumn: "FarmerId");
                    table.ForeignKey(
                        name: "FK_Vehicals_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HighPrice = table.Column<double>(type: "float", nullable: true),
                    LowPrice = table.Column<double>(type: "float", nullable: true),
                    AvgPrice = table.Column<double>(type: "float", nullable: true),
                    BuyerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Employees_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Employees",
                        principalColumn: "BuyerId");
                });

            migrationBuilder.CreateTable(
                name: "FarmerProduct",
                columns: table => new
                {
                    FarmersFarmerId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmerProduct", x => new { x.FarmersFarmerId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_FarmerProduct_Farmers_FarmersFarmerId",
                        column: x => x.FarmersFarmerId,
                        principalTable: "Farmers",
                        principalColumn: "FarmerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FarmerProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarketProduct",
                columns: table => new
                {
                    MarketsMarketId = table.Column<int>(type: "int", nullable: false),
                    ProductsProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketProduct", x => new { x.MarketsMarketId, x.ProductsProductId });
                    table.ForeignKey(
                        name: "FK_MarketProduct_Markets_MarketsMarketId",
                        column: x => x.MarketsMarketId,
                        principalTable: "Markets",
                        principalColumn: "MarketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarketProduct_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_MarketId",
                table: "Employees",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_FarmerMarket_MarketsMarketId",
                table: "FarmerMarket",
                column: "MarketsMarketId");

            migrationBuilder.CreateIndex(
                name: "IX_FarmerProduct_ProductsProductId",
                table: "FarmerProduct",
                column: "ProductsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketProduct_ProductsProductId",
                table: "MarketProduct",
                column: "ProductsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BuyerId",
                table: "Products",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicals_FarmerId",
                table: "Vehicals",
                column: "FarmerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicals_MarketId",
                table: "Vehicals",
                column: "MarketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FarmerMarket");

            migrationBuilder.DropTable(
                name: "FarmerProduct");

            migrationBuilder.DropTable(
                name: "MarketProduct");

            migrationBuilder.DropTable(
                name: "Vehicals");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Farmers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Markets");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.REPOSITORY.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    height = table.Column<int>(type: "int", nullable: false),
                    width = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdateDate" },
                values: new object[] { 1, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(616), "Pencils", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdateDate" },
                values: new object[] { 2, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(674), "Notebooks", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdateDate" },
                values: new object[] { 3, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(677), "Books", null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoriesId", "CreatedDate", "Name", "Price", "Stock", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(1158), "Pencil 1", 143m, 520, null },
                    { 2, 1, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(1170), "Pencil 2", 345m, 127, null },
                    { 3, 1, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(1181), "Pencil 3", 52m, 1000, null },
                    { 4, 2, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(1248), "Notebook 1", 69m, 142, null },
                    { 5, 2, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(1254), "Notebook 2", 48m, 326, null },
                    { 6, 2, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(1257), "Notebook 3", 140m, 399, null },
                    { 7, 3, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(1260), "Book 1", 115m, 550, null },
                    { 8, 3, new DateTime(2022, 3, 30, 17, 42, 18, 467, DateTimeKind.Local).AddTicks(1268), "Book 2", 265m, 50, null }
                });

            migrationBuilder.InsertData(
                table: "productFeatures",
                columns: new[] { "Id", "Color", "ProductId", "height", "width" },
                values: new object[] { 1, "Red", 1, 8, 3 });

            migrationBuilder.InsertData(
                table: "productFeatures",
                columns: new[] { "Id", "Color", "ProductId", "height", "width" },
                values: new object[] { 2, "Purple", 4, 25, 15 });

            migrationBuilder.CreateIndex(
                name: "IX_productFeatures_ProductId",
                table: "productFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesId",
                table: "Products",
                column: "CategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productFeatures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

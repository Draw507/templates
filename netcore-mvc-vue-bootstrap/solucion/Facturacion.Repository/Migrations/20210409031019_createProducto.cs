using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Facturacion.Repository.Migrations
{
    public partial class createProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: true),
                    Cantidad = table.Column<int>(type: "integer", nullable: false),
                    UnidadMedida = table.Column<int>(type: "integer", nullable: false),
                    BodegaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Producto_bodega_BodegaId",
                        column: x => x.BodegaId,
                        principalTable: "bodega",
                        principalColumn: "bodegaid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetPermissions",
                keyColumn: "Id",
                keyValue: new Guid("8bdab0fe-ede2-40f1-94d5-d1188631f7c2"),
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 22, 10, 17, 353, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "AspNetRolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("4b42c9be-d71f-49cf-8f66-19e30d6e49d1"),
                column: "DateCreated",
                value: new DateTime(2021, 4, 8, 22, 10, 17, 360, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "494c9445-531c-4925-98b7-805017144dd5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "319fa891-fec4-4dfd-a436-d2aa057cfec0", "AQAAAAEAACcQAAAAELUKXY1q3udQr4QSvITQslfn9c5pPUWsNhMvB4ynXAEGsX2i4/nYSK27G10QZ9lWtQ==", "08b9b492-317f-4a40-8054-30fdfc80252e" });

            migrationBuilder.CreateIndex(
                name: "IX_Producto_BodegaId",
                table: "Producto",
                column: "BodegaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.UpdateData(
                table: "AspNetPermissions",
                keyColumn: "Id",
                keyValue: new Guid("8bdab0fe-ede2-40f1-94d5-d1188631f7c2"),
                column: "DateCreated",
                value: new DateTime(2021, 3, 16, 16, 38, 12, 119, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "AspNetRolePermissions",
                keyColumn: "Id",
                keyValue: new Guid("4b42c9be-d71f-49cf-8f66-19e30d6e49d1"),
                column: "DateCreated",
                value: new DateTime(2021, 3, 16, 16, 38, 12, 122, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "47dcf7ab-88f5-4016-b4a1-53fbf960a9dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8d9642d-43e7-4e27-857a-82447e34a4be", "AQAAAAEAACcQAAAAEJR1uzr6aJHHfIp7omoLMhjYhWZVp0iz8sjfuHj+Qyw2ypscS1aFYEP8H+HyaYKNgQ==", "d6df9b6c-8bee-42c2-b453-1909611df332" });
        }
    }
}

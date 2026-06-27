using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMS.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreationDate", "Description", "LastUpdated", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 100001, new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4171), "Test product for demonstration", new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4172), "Sample Product", 10.0, 100 },
                    { 100002, new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4173), "High-end laptop for professionals", new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4174), "Laptop Pro", 1500.0, 50 },
                    { 100003, new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4175), "Ergonomic wireless mouse", new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4175), "Wireless Mouse", 50.0, 200 },
                    { 100004, new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4177), "Comfortable office chair", new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4177), "Office Chair", 150.0, 100 },
                    { 100005, new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4178), "Latest smartphone with advanced features", new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4178), "Smartphone X", 999.0, 75 },
                    { 100006, new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4179), "Next-gen gaming console", new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4180), "Gaming Console", 499.0, 30 },
                    { 100007, new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4181), "Portable Bluetooth speaker with high-quality sound", new DateTime(2026, 5, 4, 15, 57, 56, 97, DateTimeKind.Utc).AddTicks(4181), "Bluetooth Speaker", 120.0, 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100001);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100002);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100003);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100004);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100005);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100006);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100007);
        }
    }
}

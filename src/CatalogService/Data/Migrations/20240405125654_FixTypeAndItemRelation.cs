﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogService.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixTypeAndItemRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_catalog_CatalogTypeId",
                table: "catalog");

            migrationBuilder.CreateIndex(
                name: "IX_catalog_CatalogTypeId",
                table: "catalog",
                column: "CatalogTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_catalog_CatalogTypeId",
                table: "catalog");

            migrationBuilder.CreateIndex(
                name: "IX_catalog_CatalogTypeId",
                table: "catalog",
                column: "CatalogTypeId",
                unique: true);
        }
    }
}

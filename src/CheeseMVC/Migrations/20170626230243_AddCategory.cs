using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeseMVC.Migrations
{
    public partial class AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Cheeses",
                newName: "CheeseCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Cheeses_CheeseCategoryID",
                table: "Cheeses",
                column: "CheeseCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cheeses_CheeseCategories_CheeseCategoryID",
                table: "Cheeses",
                column: "CheeseCategoryID",
                principalTable: "CheeseCategories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cheeses_CheeseCategories_CheeseCategoryID",
                table: "Cheeses");

            migrationBuilder.DropIndex(
                name: "IX_Cheeses_CheeseCategoryID",
                table: "Cheeses");

            migrationBuilder.RenameColumn(
                name: "CheeseCategoryID",
                table: "Cheeses",
                newName: "Type");
        }
    }
}

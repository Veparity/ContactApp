using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactApp.Data.Migrations
{
    public partial class TaableNameUpdate_0006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryContact_Categories_CatergoriesId",
                table: "CategoryContact");

            migrationBuilder.RenameColumn(
                name: "CatergoriesId",
                table: "CategoryContact",
                newName: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryContact_Categories_CategoriesId",
                table: "CategoryContact",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryContact_Categories_CategoriesId",
                table: "CategoryContact");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "CategoryContact",
                newName: "CatergoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryContact_Categories_CatergoriesId",
                table: "CategoryContact",
                column: "CatergoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

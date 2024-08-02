using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class tableBlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_AspNetUsers_AppUserId",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategory_Blog_BlogId",
                table: "BlogCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategory_Categories_CategoryId",
                table: "BlogCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogCategory",
                table: "BlogCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blog",
                table: "Blog");

            migrationBuilder.RenameTable(
                name: "BlogCategory",
                newName: "BlogCategories");

            migrationBuilder.RenameTable(
                name: "Blog",
                newName: "Blogs");

            migrationBuilder.RenameIndex(
                name: "IX_BlogCategory_CategoryId",
                table: "BlogCategories",
                newName: "IX_BlogCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogCategory_BlogId",
                table: "BlogCategories",
                newName: "IX_BlogCategories_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Blog_AppUserId",
                table: "Blogs",
                newName: "IX_Blogs_AppUserId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 28, 1, 51, 22, 123, DateTimeKind.Local).AddTicks(9078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 2, 27, 34, 552, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogCategories",
                table: "BlogCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategories_Blogs_BlogId",
                table: "BlogCategories",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategories_Categories_CategoryId",
                table: "BlogCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_AppUserId",
                table: "Blogs",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategories_Blogs_BlogId",
                table: "BlogCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogCategories_Categories_CategoryId",
                table: "BlogCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_AppUserId",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogCategories",
                table: "BlogCategories");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Blog");

            migrationBuilder.RenameTable(
                name: "BlogCategories",
                newName: "BlogCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_AppUserId",
                table: "Blog",
                newName: "IX_Blog_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogCategories_CategoryId",
                table: "BlogCategory",
                newName: "IX_BlogCategory_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_BlogCategories_BlogId",
                table: "BlogCategory",
                newName: "IX_BlogCategory_BlogId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 2, 27, 34, 552, DateTimeKind.Local).AddTicks(4740),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 28, 1, 51, 22, 123, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blog",
                table: "Blog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogCategory",
                table: "BlogCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_AspNetUsers_AppUserId",
                table: "Blog",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategory_Blog_BlogId",
                table: "BlogCategory",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogCategory_Categories_CategoryId",
                table: "BlogCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

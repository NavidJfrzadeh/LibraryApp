using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infra.DataBase.SQLServer.EF.Migrations
{
    /// <inheritdoc />
    public partial class addConfigureForBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_customers_CustomerId",
                table: "books");

            migrationBuilder.AddForeignKey(
                name: "FK_books_customers_CustomerId",
                table: "books",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_customers_CustomerId",
                table: "books");

            migrationBuilder.AddForeignKey(
                name: "FK_books_customers_CustomerId",
                table: "books",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id");
        }
    }
}

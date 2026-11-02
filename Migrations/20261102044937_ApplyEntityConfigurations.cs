using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tidy.Migrations
{
    /// <inheritdoc />
    public partial class ApplyEntityConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FileItems_Hash",
                table: "FileItems",
                column: "Hash");

            migrationBuilder.CreateIndex(
                name: "IX_FileItems_Path",
                table: "FileItems",
                column: "Path",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FileItems_Hash",
                table: "FileItems");

            migrationBuilder.DropIndex(
                name: "IX_FileItems_Path",
                table: "FileItems");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BtkAkademiAIblog.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class FixArticleModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Articles",
                newName: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Articles",
                newName: "Id");
        }
    }
}

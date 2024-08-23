using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bdo.gptVisionApi.Migrations
{
    /// <inheritdoc />
    public partial class AddUserEmailToChatEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "ChatEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "ChatEntries");
        }
    }
}

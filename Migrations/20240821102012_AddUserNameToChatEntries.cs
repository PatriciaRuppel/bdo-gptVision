using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bdo.gptVisionApi.Migrations
{
    /// <inheritdoc />
    public partial class AddUserNameToChatEntries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "ChatEntries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "ChatEntries");
        }
    }
}

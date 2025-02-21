using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInterestsToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LookinFor",
                table: "Users",
                newName: "LookingFor");

            migrationBuilder.RenameColumn(
                name: "Intrests",
                table: "Users",
                newName: "Interests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LookingFor",
                table: "Users",
                newName: "LookinFor");

            migrationBuilder.RenameColumn(
                name: "Interests",
                table: "Users",
                newName: "Intrests");
        }
    }
}

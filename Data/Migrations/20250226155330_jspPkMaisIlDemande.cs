using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HTDPlaces.Data.Migrations
{
    /// <inheritdoc />
    public partial class jspPkMaisIlDemande : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorEmail",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorEmail",
                table: "Events");
        }
    }
}

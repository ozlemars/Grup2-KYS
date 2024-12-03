using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KYS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sonKurulum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AvailabilityStatus",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailabilityStatus",
                table: "Books");
        }
    }
}

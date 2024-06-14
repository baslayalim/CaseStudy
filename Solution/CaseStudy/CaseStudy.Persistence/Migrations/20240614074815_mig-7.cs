using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaseStudy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "ServiceIntegrations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "ServiceIntegrations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

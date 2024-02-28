using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaseStudy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Customers",
                comment: "Müşteri Tablosu - Müşteri Bİlgileri Tutulur");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Customers",
                oldComment: "Müşteri Tablosu - Müşteri Bİlgileri Tutulur");
        }
    }
}

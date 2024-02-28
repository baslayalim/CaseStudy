using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaseStudy.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "local_storage_table",
                table: "Customers",
                type: "int",
                nullable: false,
                comment: "Sayfaya Ait Js Kodunun Tutulduğu Alan",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Customers",
                type: "varchar(300)",
                nullable: true,
                comment: "Müşteri Soyismi Tutulur",
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Müşteri İsmi Tutulur",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "local_storage_table",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Sayfaya Ait Js Kodunun Tutulduğu Alan");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Customers",
                type: "varchar(300)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldNullable: true,
                oldComment: "Müşteri Soyismi Tutulur");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Müşteri İsmi Tutulur");
        }
    }
}

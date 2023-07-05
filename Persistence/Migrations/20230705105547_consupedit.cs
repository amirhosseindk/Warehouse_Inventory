using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class consupedit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SupplierPhone",
                table: "Suppliers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "SupplierName",
                table: "Suppliers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SupplierEmail",
                table: "Suppliers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "ConsumerPhone",
                table: "Consumers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "ConsumerName",
                table: "Consumers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ConsumerEmail",
                table: "Consumers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Consumers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Consumers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Consumers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Consumers");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Suppliers",
                newName: "SupplierPhone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Suppliers",
                newName: "SupplierName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Suppliers",
                newName: "SupplierEmail");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Consumers",
                newName: "ConsumerPhone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Consumers",
                newName: "ConsumerName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Consumers",
                newName: "ConsumerEmail");
        }
    }
}

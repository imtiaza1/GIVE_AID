using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GIVE_AID.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDonationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Donation",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CVV",
                table: "Donation",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardName",
                table: "Donation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Donation",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "Donation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExpiryDate",
                table: "Donation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "CardName",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "CardType",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                table: "Donation");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Donation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}

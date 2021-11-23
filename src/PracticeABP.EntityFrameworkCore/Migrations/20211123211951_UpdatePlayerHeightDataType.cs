using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeABP.Migrations
{
    public partial class UpdatePlayerHeightDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "Players",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Height",
                table: "Players",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace H_EstateAgency2.Migrations
{
    public partial class description23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ppurpose",
                table: "Properties",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ppurpose",
                table: "Properties");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace H_EstateAgency2.Migrations
{
    public partial class description2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Purpose",
                columns: table => new
                {
                    purposeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purposefor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purpose", x => x.purposeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purpose");
        }
    }
}

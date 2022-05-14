using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRelationships.Migrations
{
    public partial class AddTypeColumnAtCharaterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Characters");
        }
    }
}

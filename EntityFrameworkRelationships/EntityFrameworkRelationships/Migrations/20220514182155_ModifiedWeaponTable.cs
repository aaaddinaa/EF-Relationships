using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRelationships.Migrations
{
    public partial class ModifiedWeaponTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapon_Characters_CharacterID",
                table: "Weapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon");

            migrationBuilder.RenameTable(
                name: "Weapon",
                newName: "Weapons");

            migrationBuilder.RenameIndex(
                name: "IX_Weapon_CharacterID",
                table: "Weapons",
                newName: "IX_Weapons_CharacterID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Characters_CharacterID",
                table: "Weapons",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Characters_CharacterID",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons");

            migrationBuilder.RenameTable(
                name: "Weapons",
                newName: "Weapon");

            migrationBuilder.RenameIndex(
                name: "IX_Weapons_CharacterID",
                table: "Weapon",
                newName: "IX_Weapon_CharacterID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapon_Characters_CharacterID",
                table: "Weapon",
                column: "CharacterID",
                principalTable: "Characters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRelationships.Migrations
{
    public partial class SkillsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_Skill_SkillsID",
                table: "CharacterSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skill",
                table: "Skill");

            migrationBuilder.RenameTable(
                name: "Skill",
                newName: "Skills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_Skills_SkillsID",
                table: "CharacterSkill",
                column: "SkillsID",
                principalTable: "Skills",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_Skills_SkillsID",
                table: "CharacterSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "Skill");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skill",
                table: "Skill",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_Skill_SkillsID",
                table: "CharacterSkill",
                column: "SkillsID",
                principalTable: "Skill",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

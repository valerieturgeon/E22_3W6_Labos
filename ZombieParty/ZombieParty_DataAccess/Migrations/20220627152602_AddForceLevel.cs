using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty_DataAccess.Migrations
{
    public partial class AddForceLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapon_Category_CategoryId",
                table: "Weapon");

            migrationBuilder.AddColumn<int>(
                name: "ForceLevelId",
                table: "Zombie",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Weapon",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Weapon",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ForceLevel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForceLevelNiv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForceLevel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zombie_ForceLevelId",
                table: "Zombie",
                column: "ForceLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapon_Category_CategoryId",
                table: "Weapon",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zombie_ForceLevel_ForceLevelId",
                table: "Zombie",
                column: "ForceLevelId",
                principalTable: "ForceLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapon_Category_CategoryId",
                table: "Weapon");

            migrationBuilder.DropForeignKey(
                name: "FK_Zombie_ForceLevel_ForceLevelId",
                table: "Zombie");

            migrationBuilder.DropTable(
                name: "ForceLevel");

            migrationBuilder.DropIndex(
                name: "IX_Zombie_ForceLevelId",
                table: "Zombie");

            migrationBuilder.DropColumn(
                name: "ForceLevelId",
                table: "Zombie");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Weapon");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Weapon",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapon_Category_CategoryId",
                table: "Weapon",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

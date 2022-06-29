using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty_DataAccess.Migrations
{
    public partial class InitProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Hunter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hunter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZombieType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZombieType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapon_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HuntingLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdventureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HunterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HuntingLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HuntingLog_Hunter_HunterId",
                        column: x => x.HunterId,
                        principalTable: "Hunter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zombie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: false),
                    ShortDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZombieTypeId = table.Column<int>(type: "int", nullable: false),
                    ForceLevelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zombie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zombie_ForceLevel_ForceLevelId",
                        column: x => x.ForceLevelId,
                        principalTable: "ForceLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zombie_ZombieType_ZombieTypeId",
                        column: x => x.ZombieTypeId,
                        principalTable: "ZombieType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZombieHuntingLog",
                columns: table => new
                {
                    Zombie_Id = table.Column<int>(type: "int", nullable: false),
                    HuntingLog_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZombieHuntingLog", x => new { x.Zombie_Id, x.HuntingLog_Id });
                    table.ForeignKey(
                        name: "FK_ZombieHuntingLog_HuntingLog_HuntingLog_Id",
                        column: x => x.HuntingLog_Id,
                        principalTable: "HuntingLog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZombieHuntingLog_Zombie_Zombie_Id",
                        column: x => x.Zombie_Id,
                        principalTable: "Zombie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ForceLevel",
                columns: new[] { "Id", "ForceLevelNiv" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "ZombieType",
                columns: new[] { "Id", "Point", "TypeName" },
                values: new object[,]
                {
                    { 1, 0, "Contact" },
                    { 2, 0, "Virus" },
                    { 3, 0, "Chimique" },
                    { 4, 0, "Morsure" },
                    { 5, 0, "vampzombie" }
                });

            migrationBuilder.InsertData(
                table: "Zombie",
                columns: new[] { "Id", "ForceLevelId", "Image", "Name", "Point", "ShortDesc", "ZombieTypeId" },
                values: new object[,]
                {
                    { 1, 8, "", "LeChuck", 5, "Pirate des Caraibes", 1 },
                    { 14, 2, "7180c597-7add-48a4-b33e-71de5d6fed7e.png", "The Clown", 5, "Le clown malheureux qui court après les enfants", 3 },
                    { 12, 9, "0c3c00b8-463e-4a8e-ac1a-639c1293b06d.png", "Lady Rose", 6, "", 3 },
                    { 11, 9, "89935c4d-41c1-469b-87f2-ca588af035c5.png", "Avogadro", 9, "Attaque avec des éclairs suite à un orage", 3 },
                    { 10, 5, "5efefdf4-26c9-490e-b038-11b3e51af2c1.png", "chien de l'enfer", 7, "chien très rapide, pouvant être enflammé", 3 },
                    { 9, 3, "4dab96ad-a1cc-44b3-99f5-804d4e5fac81.png", "Singe zombie", 2, "Voleur très rapide", 3 },
                    { 7, 1, "d8ffd3ac-79ef-4a9e-8287-9171acb3744c.png", "Taxidermy ", 1, "Tête de cerf empaillé, voisin de Lenore", 3 },
                    { 16, 9, "3c337bf8-7871-4acc-99a7-90829830c54a.png", "TeamsZombie", 10, "L'étudiant happé par Teams. Trop d'heures de vidéos ont transformé cet étudiant en zombie", 3 },
                    { 4, 9, "8b2eaef1-45c3-4b32-9a6a-80173ceafd3b.png", "Draugr", 2, "Vivant dans sa tombe grandant son trésor", 3 },
                    { 13, 10, "d878df80-bb9f-470b-a328-a641b2c911d1.png", "Matbeth", 2, "Jeune étudiante qui cherche son professeur pour se venger", 2 },
                    { 5, 4, "9bf4cadc-8d64-4aa5-b3b9-a481460e69b5.png", "Ragamuffin ", 5, "Ancien vampire transformé en poupée de chiffon, ami de Lenore", 2 },
                    { 3, 4, "02cdda86-0430-465a-acf5-d7ae3679bf97.png", "Baron Samedi", 8, "En costume de soirée, avec un chapeau haut de forme blanc et des lunettes soleil", 2 },
                    { 2, 6, "c7be9999-3b37-4d97-a131-914a4d15009a.png", "Lenore", 4, "Cute Little Dead Girl", 2 },
                    { 8, 9, "548bb040-9748-43f0-98f6-64e4e3ae7b80.png", "Kitty", 3, "Chat mort de Lenore", 1 },
                    { 6, 3, "8b3e0771-da5a-4890-aad2-4eb5d91a38c2.png", "Mr Gosh", 6, "Tête de sac avec yeux en boutons, amoureux de Lenore", 1 },
                    { 15, 5, "97d242a7-eef2-4f88-b5ac-9dd73504284b.png", "Clicker", 4, "Le comptable mécontent qui cherche les failles", 2 },
                    { 17, 7, "98b6987a-c4f8-462c-9a99-e9163138fb5a.png", "Mathilde", 4, "La fêtarde du samedi soir qui cherche les fêtes et les bars en vogue", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HuntingLog_HunterId",
                table: "HuntingLog",
                column: "HunterId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_CategoryId",
                table: "Weapon",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Zombie_ForceLevelId",
                table: "Zombie",
                column: "ForceLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Zombie_ZombieTypeId",
                table: "Zombie",
                column: "ZombieTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ZombieHuntingLog_HuntingLog_Id",
                table: "ZombieHuntingLog",
                column: "HuntingLog_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "ZombieHuntingLog");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "HuntingLog");

            migrationBuilder.DropTable(
                name: "Zombie");

            migrationBuilder.DropTable(
                name: "Hunter");

            migrationBuilder.DropTable(
                name: "ForceLevel");

            migrationBuilder.DropTable(
                name: "ZombieType");
        }
    }
}

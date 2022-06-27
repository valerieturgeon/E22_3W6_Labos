using Microsoft.EntityFrameworkCore.Migrations;

namespace ZombieParty_DataAccess.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 1, 8, null, "LeChuck", 5, "Pirate des Caraibes", 1 },
                    { 14, 2, null, "The Clown", 5, "Le clown malheureux qui court après les enfants", 3 },
                    { 12, 9, null, "Lady Rose", 6, "", 3 },
                    { 11, 9, null, "Avogadro", 9, "Attaque avec des éclairs suite à un orage", 3 },
                    { 10, 5, null, "chien de l'enfer", 7, "chien très rapide, pouvant être enflammé", 3 },
                    { 9, 3, null, "Singe zombie", 2, "Voleur très rapide", 3 },
                    { 7, 1, null, "Taxidermy ", 1, "Tête de cerf empaillé, voisin de Lenore", 3 },
                    { 16, 9, null, "TeamsZombie", 10, "L'étudiant happé par Teams. Trop d'heures de vidéos ont transformé cet étudiant en zombie", 3 },
                    { 4, 9, null, "Draugr", 2, "Vivant dans sa tombe grandant son trésor", 3 },
                    { 13, 10, null, "Matbeth", 2, "Jeune étudiante qui cherche son professeur pour se venger", 2 },
                    { 5, 4, null, "Ragamuffin ", 5, "Ancien vampire transformé en poupée de chiffon, ami de Lenore", 2 },
                    { 3, 4, null, "Baron Samedi", 8, "En costume de soirée, avec un chapeau haut de forme blanc et des lunettes soleil", 2 },
                    { 2, 6, null, "Lenore", 4, "Cute Little Dead Girl", 2 },
                    { 8, 9, null, "Kitty", 3, "Chat mort de Lenore", 1 },
                    { 6, 3, null, "Mr Gosh", 6, "Tête de sac avec yeux en boutons, amoureux de Lenore", 1 },
                    { 15, 5, null, "Clicker", 4, "Le comptable mécontent qui cherche les failles", 2 },
                    { 17, 7, null, "Mathilde", 4, "La fêtarde du samedi soir qui cherche les fêtes et les bars en vogue", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Zombie",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ForceLevel",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ZombieType",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ChampsSpeciaux.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Travel",
                columns: new[] { "Id", "Description", "Name", "TravelImage" },
                values: new object[] { 1, "<span class='ILfuVd'>Le <b>ski</b> de pente raide, ou <b>ski extrême</b>, est une discipline du <b>ski</b> qui conjugue alpinisme et <b>ski</b>de montagne et se pratique dans un couloir ou sur une pente généralement au départ d'un sommet que l'''on atteint après une ascension à pied et / ou à < b > ski </ b > en mettant parfois en œuvre du matériel d'''alpinisme (piolets, crampons).</span>", "Ski Extrême", "9f8d9bc0-f597-483f-84af-4665d4df15a3.png" });

            migrationBuilder.InsertData(
                table: "Travel",
                columns: new[] { "Id", "Description", "Name", "TravelImage" },
                values: new object[] { 2, "<p>La <font color='#9c00ff'><b>montgolfière</b></font> a toujours marqué l''’imaginaire. Capable de revêtir n''’importe quelle couleur, elle inspire par sa beauté et sa grandeur. <u>Synonyme</u> d’''aventure, elle a aussi fait l'’'objet de nombreux récits, qui racontent les péripéties de voyages intrépides vers l’inconnu. Riche en histoire, les origines de cette invention nous viennent d'’'une époque lointaine. Aujourd’hui, elle continue d’émerveiller par sa capacité à s’élever, pratiquement comme par magie<br></p>", "Montgolfière", "b7c32080-b025-47bb-a05c-858857795fb9.png" });

            migrationBuilder.InsertData(
                table: "Travel",
                columns: new[] { "Id", "Description", "Name", "TravelImage" },
                values: new object[] { 3, "<p><b>Kalymnos</b> est une île grecque montagneuse de l’archipel du <font color='#000000' style='background - color: rgb(255, 255, 0); '>Dodécanèse</font> dans la mer Égée. Elle attire à chaque année de nombreux grimpeurs venus surmonter ses falaises de calcaire. Ces dernières offrent tous les styles d''’escalade qui conviendront aux grimpeurs de tous les niveaux.<br></p>", "escalade", "4035923b-acbe-4ca5-a199-a2eb978325fe.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Travel",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

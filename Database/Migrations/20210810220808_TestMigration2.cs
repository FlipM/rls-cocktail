using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RLS.AwesomeBar.API.Database.Migrations
{
    public partial class TestMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CocktailIngredient",
                table: "CocktailIngredient");

            migrationBuilder.RenameTable(
                name: "CocktailIngredient",
                newName: "CocktailIngredients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CocktailIngredients",
                table: "CocktailIngredients",
                column: "RelationId");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Cocktail",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 250, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Cocoa",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Coffee / Tea",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Homemade Liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Milk / Float / Shake",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Ordinary Drink",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Other/Unknown",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Punch / Party Drink",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Shot",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Soft Drink / Soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "151 proof rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "7-Up",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absinthe",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Citron",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Kurant",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Peppar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Advocaat",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Agave syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Agave Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ale",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Allspice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Almond",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Almond flavoring",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Amaretto",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angelica root",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angostura bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angostura Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anis",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anise",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anisette",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Aperol",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apfelkorn",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple cider",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Applejack",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot Brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Aquavit",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Asafoetida",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "A�ejo rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bacardi Limon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bailey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Baileys irish cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Banana",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Banana liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Benedictine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Berries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bitter lemon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Black pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Black Sambuca",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackberries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackberry brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackcurrant cordial",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackcurrant squash",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "blackstrap rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blended Scotch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blended whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blue Curacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blueberry schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bourbon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Brown sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Butter",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Butterscotch schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cachaca",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Campari",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Candy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cantaloupe",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Caramel coloring",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "caramel sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carbonated soft drink",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carbonated water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cardamom",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carrot",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cayenne pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Celery salt",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chambord raspberry liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Champagne",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry Grenadine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry Heering",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate ice-cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate milk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "chocolate sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate Sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cider",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cinnamon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cloves",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Club soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coca-Cola",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cocoa powder",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut milk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cognac",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cointreau",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Condensed milk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coriander",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Corn syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cornstarch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Corona",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cream of coconut",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Banane",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Cacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Cassis",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Mure",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Crown Royal",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cumin seed",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Curacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Daiquiri mix",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark Creme de Cacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark Rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "demerara Sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dr. Pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Drambuie",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dry Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dubonnet Rouge",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg white",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg White",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg yolk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg Yolk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Elderflower cordial",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Erin Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Espresso",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Everclear",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Falernum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fennel seeds",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Firewater",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Food coloring",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Frangelico",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresca",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresh Lemon Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresh Lime Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit punch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Galliano",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "gin",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gin",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger ale",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger Beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Glycerine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Godiva liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gold rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gold tequila",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Goldschlager",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grain alcohol",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grand Marnier",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape Soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapefruit juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapefruit Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapes",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Green Chartreuse",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Green Creme de Menthe",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grenadine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Guava juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Guinness stout",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Half-and-half",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Heavy cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Honey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Honey syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot Chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot Damn",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Iced tea",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish Whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Islay single malt Scotch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jack Daniels",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jagermeister",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jello",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jim Beam",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Johnnie Walker",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "J�germeister",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kahlua",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kirschwasser",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kiwi",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kiwi liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kool-Aid",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kummel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lager",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lavender",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "lemon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "lemon juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon peel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon-lime soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemonade",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Licorice root",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Light cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Light rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 252, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lillet",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lillet Blanc",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime juice cordial",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime peel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Limeade",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Malibu rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mango",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maple syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino cherry",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino Cherry",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "maraschino liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino Liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Marjoram leaves",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Marshmallows",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maui",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Melon liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mezcal",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Midori melon liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Milk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mini-snickers bars",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mint",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mint syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mountain Dew",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Nutmeg",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Olive",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Olive Brine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Curacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "orange juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange peel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Peel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange spiral",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Oreo cookie",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orgeat syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ouzo",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Papaya",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passion fruit juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passion fruit syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passoa",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach nectar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach Vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peachtree schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peppermint extract",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peppermint schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pepsi Cola",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pernod",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peychaud bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pina colada mix",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "pineapple juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pink lemonade",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pisang Ambon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pisco",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Port",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Powdered sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Prosecco",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry Liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Red wine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ricard",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Root beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rosemary",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rosso Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rumple Minze",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rye whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Salt",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Salted Chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sambuca",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sarsaparilla",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Schweppes Russchian",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Scotch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sherbet",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sherry",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sirup of roses",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sloe gin",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Soda water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Soda Water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sour mix",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Southern Comfort",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1631));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Spiced rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sprite",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "St. Germain",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberry liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberry schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Surge",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet and sour",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet and Sour",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tabasco sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tea",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tennessee whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tequila",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tia maria",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tomato juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tomato Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tonic water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tonic Water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Triple sec",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Triple Sec",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tropicana",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla extract",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla ice-cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla Ice-Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipped cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipped Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipping cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whisky",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White Creme de Menthe",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White Rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 254, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wild Turkey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Worcestershire sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wormwood",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yellow Chartreuse",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yoghurt",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yukon Jack",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Zima",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 22, 8, 7, 253, DateTimeKind.Utc).AddTicks(9003));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CocktailIngredients",
                table: "CocktailIngredients");

            migrationBuilder.RenameTable(
                name: "CocktailIngredients",
                newName: "CocktailIngredient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CocktailIngredient",
                table: "CocktailIngredient",
                column: "RelationId");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Cocktail",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 299, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Cocoa",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Coffee / Tea",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Homemade Liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Milk / Float / Shake",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Ordinary Drink",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Other/Unknown",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Punch / Party Drink",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Shot",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Name",
                keyValue: "Soft Drink / Soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 300, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "151 proof rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "7-Up",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absinthe",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Citron",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Kurant",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Peppar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Absolut Vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Advocaat",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Agave syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Agave Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ale",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Allspice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Almond",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Almond flavoring",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Amaretto",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angelica root",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angostura bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Angostura Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anis",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anise",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Anisette",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Aperol",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apfelkorn",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple cider",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apple schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Applejack",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Apricot Brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Aquavit",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Asafoetida",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "A�ejo rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bacardi Limon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bailey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Baileys irish cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Banana",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Banana liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Benedictine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Berries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bitter lemon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Black pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Black Sambuca",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackberries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackberry brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackcurrant cordial",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blackcurrant squash",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "blackstrap rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blended Scotch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blended whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blue Curacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Blueberry schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Bourbon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Brown sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Butter",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Butterscotch schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cachaca",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Campari",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Candy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cantaloupe",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Caramel coloring",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "caramel sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carbonated soft drink",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carbonated water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cardamom",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Carrot",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cayenne pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Celery salt",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chambord raspberry liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Champagne",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry Grenadine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry Heering",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cherry liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate ice-cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate milk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "chocolate sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate Sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Chocolate syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cider",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cinnamon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cloves",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Club soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coca-Cola",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cocoa powder",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut milk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coconut syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coffee liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cognac",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cointreau",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Condensed milk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Coriander",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Corn syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cornstarch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Corona",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cranberry vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cream of coconut",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Banane",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Cacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Cassis",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Creme de Mure",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Crown Royal",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Cumin seed",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Curacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Daiquiri mix",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark Creme de Cacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dark Rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "demerara Sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dr. Pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Drambuie",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dry Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Dubonnet Rouge",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg white",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg White",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg yolk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Egg Yolk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Elderflower cordial",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Erin Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Espresso",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Everclear",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Falernum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fennel seeds",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Firewater",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Food coloring",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Frangelico",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresca",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresh Lemon Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fresh Lime Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Fruit punch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Galliano",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "gin",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gin",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger ale",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger Beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ginger Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Glycerine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Godiva liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gold rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Gold tequila",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Goldschlager",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grain alcohol",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grand Marnier",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grape Soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapefruit juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapefruit Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grapes",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Green Chartreuse",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Green Creme de Menthe",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Grenadine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Guava juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Guinness stout",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Half-and-half",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Heavy cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Honey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Honey syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot Chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Hot Damn",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Iced tea",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Irish Whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Islay single malt Scotch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jack Daniels",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jagermeister",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jello",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Jim Beam",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Johnnie Walker",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "J�germeister",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kahlua",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kirschwasser",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kiwi",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kiwi liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kool-Aid",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Kummel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lager",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lavender",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "lemon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "lemon juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon peel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemon-lime soda",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lemonade",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Licorice root",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Light cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Light rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lillet",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lillet Blanc",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime juice cordial",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime peel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Lime vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Limeade",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Malibu rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mango",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maple syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino cherry",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino Cherry",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "maraschino liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maraschino Liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Marjoram leaves",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Marshmallows",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Maui",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Melon liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mezcal",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Midori melon liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Milk",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mini-snickers bars",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mint",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mint syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Mountain Dew",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Nutmeg",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Olive",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Olive Brine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Curacao",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "orange juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange peel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange Peel",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orange spiral",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Oreo cookie",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Orgeat syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ouzo",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Papaya",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passion fruit juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passion fruit syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Passoa",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach Bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach brandy",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach nectar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peach Vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peachtree schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pepper",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peppermint extract",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peppermint schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pepsi Cola",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pernod",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Peychaud bitters",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pina colada mix",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "pineapple juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pineapple Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pink lemonade",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pisang Ambon",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Pisco",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Port",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Powdered sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Prosecco",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry Liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Raspberry vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Red wine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Ricard",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Root beer",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rosemary",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rosso Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rumple Minze",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Rye whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Salt",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Salted Chocolate",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sambuca",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sarsaparilla",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Schweppes Russchian",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Scotch",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sherbet",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sherry",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sirup of roses",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sloe gin",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Soda water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Soda Water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sour mix",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Southern Comfort",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Spiced rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sprite",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "St. Germain",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberries",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberry liqueur",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Strawberry schnapps",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sugar Syrup",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Surge",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet and sour",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet and Sour",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Sweet Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tabasco sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tea",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tennessee whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tequila",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tia maria",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tomato juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tomato Juice",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tonic water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tonic Water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Triple sec",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Triple Sec",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Tropicana",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla extract",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla ice-cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla Ice-Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vanilla vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vermouth",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Vodka",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Water",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipped cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipped Cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whipping cream",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whiskey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Whisky",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White Creme de Menthe",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "White Rum",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 302, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wild Turkey",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wine",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Worcestershire sauce",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Wormwood",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yellow Chartreuse",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yoghurt",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Yukon Jack",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Name",
                keyValue: "Zima",
                column: "CreatedAt",
                value: new DateTime(2021, 8, 10, 18, 3, 54, 301, DateTimeKind.Utc).AddTicks(9977));
        }
    }
}

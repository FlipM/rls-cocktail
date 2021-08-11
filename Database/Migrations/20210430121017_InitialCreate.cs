using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RLS.AwesomeBar.API.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cocktail", new DateTime(2021, 4, 30, 12, 10, 17, 394, DateTimeKind.Utc).AddTicks(9218), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Soft Drink / Soda", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6993), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Homemade Liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6910), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coffee / Tea", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6885), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Shot", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6781), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Beer", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6950), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Other/Unknown", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6737), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Milk / Float / Shake", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6727), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Punch / Party Drink", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6560), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ordinary Drink", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6419), null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cocoa", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(6766), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pisang Ambon", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2924), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Vanilla vodka", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3032), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Dark Creme de Cacao", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3017), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Malibu rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3007), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Creme de Banane", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2984), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Hot chocolate", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2972), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cherry Heering", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2952), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Bitter lemon", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2933), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Absolut Kurant", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2896), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coconut liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2789), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Chambord raspberry liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2840), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Vermouth", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2820), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Crown Royal", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2799), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Wild Turkey", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3048), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Butterscotch schnapps", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2775), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Absolut Vodka", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2755), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Daiquiri mix", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2746), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pina colada mix", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2737), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Godiva liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2883), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Grape soda", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3058), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Jello", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3133), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Banana liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3085), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Strawberry liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3441), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Kirschwasser", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3433), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Chocolate milk", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3419), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Aquavit", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3400), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Root beer", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3354), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cherries", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3344), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tropicana", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3331), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coconut rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3319), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Yukon Jack", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3299), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Bacardi Limon", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3263), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Corona", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3253), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Schweppes Russchian", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3236), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Apfelkorn", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3228), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cranberry vodka", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3180), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Fruit punch", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3144), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Jim Beam", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2726), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Surge", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3122), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Peachtree schnapps", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3114), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Kiwi liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3096), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Candy", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3068), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Jack Daniels", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2712), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Iced tea", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2642), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Apple schnapps", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2679), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sour mix", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2370), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Frangelico", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2353), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Blackcurrant cordial", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2320), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cider", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2312), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lager", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2303), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cherry liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2288), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Absolut Peppar", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2276), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Firewater", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2268), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Whiskey", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2380), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Peach nectar", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2237), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sherbet", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2197), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Carbonated soft drink", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2188), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Kool-Aid", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2155), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Everclear", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2145), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Rye whiskey", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2133), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Apple cider", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2119), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Guava juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2106), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Brown sugar", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2095), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Fresca", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2223), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Hot Damn", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2388), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Midori melon liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2402), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Beer", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2413), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "7-Up", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2670), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sarsaparilla", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2660), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Black Sambuca", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3458), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pink lemonade", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2631), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sprite", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2623), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Oreo cookie", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2575), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Vanilla ice-cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2567), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Passion fruit syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2552), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Advocaat", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2542), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Erin Cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2533), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sambuca", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2511), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Chocolate liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2499), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Guinness stout", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2489), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ale", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2481), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Goldschlager", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2471), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Irish cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2462), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pisco", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2451), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "White rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2441), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Dr. Pepper", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2426), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Peppermint schnapps", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2696), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Blackcurrant squash", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3469), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Whisky", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3603), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pepsi Cola", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3514), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Maraschino Cherry", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4509), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Salted Chocolate", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4499), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Chocolate Sauce", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4490), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "lemon", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4478), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Fresh Lime Juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4465), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Fresh Lemon Juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4448), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Egg White", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4395), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cranberry Juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4383), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Blackberries", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4519), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Mini-snickers bars", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4368), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "caramel sauce", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4351), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Whipped Cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4343), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Vanilla Ice-Cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4330), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "White Rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4314), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lillet Blanc", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4304), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tomato Juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4292), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Agave syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4281), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Soda Water", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4270), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "chocolate sauce", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4359), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Gold rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4529), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pernod", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4539), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ginger beer", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4552), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Islay single malt Scotch", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4803), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ginger Syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4794), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Honey syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4786), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Blended Scotch", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4776), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Irish Whiskey", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4761), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Hot Chocolate", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4750), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Rosso Vermouth", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4738), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Elderflower cordial", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4730), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Passoa", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4718), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sweet and Sour", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4706), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Jagermeister", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4693), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Bailey", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4684), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Grape Soda", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4665), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orange Bitters", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4647), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orange Peel", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4636), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lillet", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4627), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Mezcal", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4613), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Rosemary", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4604), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tonic Water", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4595), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sugar Syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4260), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "pineapple juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4249), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Raspberry Liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4240), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ginger Beer", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4229), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Agave Syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3874), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lemon Juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3866), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cherry Grenadine", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3855), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Triple Sec", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3846), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Raspberry vodka", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3831), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Maui", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3810), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Blueberry schnapps", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3794), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Gold tequila", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3776), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lime juice cordial", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3765), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Rumple Minze", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3752), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Corn syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3739), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Mountain Dew", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3716), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Melon liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3707), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Limeade", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3671), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tennessee whiskey", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3620), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Fennel seeds", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2084), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Absinthe", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3564), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cream of coconut", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3547), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orange Curacao", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3531), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "demerara Sugar", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3910), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Zima", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3479), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "lemon juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3924), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Olive Brine", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3945), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Dark Rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4220), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Creme de Mure", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4210), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Prosecco", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4199), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pineapple Juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4189), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coconut milk", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4148), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Maraschino Liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4124), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Grapefruit Juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4115), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "orange juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4102), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Egg Yolk", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4073), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orange Juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4060), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Apricot Brandy", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4051), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Peach Bitters", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4034), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "gin", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4025), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lavender", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3999), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pepper", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3990), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Angostura Bitters", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3982), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "St. Germain", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3974), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pineapple Syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3965), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lime Juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3956), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "maraschino liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(3933), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Johnnie Walker", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2074), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Allspice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1973), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Peppermint extract", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2027), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tomato juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(180), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coffee liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(161), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Carbonated water", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(151), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Banana", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(137), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Scotch", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(123), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Bitters", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(114), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Grand Marnier", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(102), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Green Creme de Menthe", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(92), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tabasco sauce", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(189), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Champagne", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(83), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Wine", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(41), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orange", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(32), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Applejack", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(19), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Apple brandy", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(9), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Whipped cream", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9999), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tea", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9989), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "White Creme de Menthe", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9980), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Club soda", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9970), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Benedictine", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(72), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Celery salt", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(220), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Worcestershire sauce", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(233), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Blue Curacao", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(244), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Strawberries", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(612), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orange spiral", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(583), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tonic water", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(571), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pineapple", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(555), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sugar syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(478), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Dubonnet Rouge", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(455), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Chocolate ice-cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(433), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Port", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(420), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cherry brandy", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(409), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cognac", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(398), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Egg yolk", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(386), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cachaca", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(366), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Egg", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(350), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Grenadine", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(334), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Maraschino liqueur", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(306), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orange juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(287), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tia maria", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(277), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "A�ejo rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(268), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lemonade", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(253), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Egg white", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9952), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Kahlua", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9944), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Dark rum", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9935), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Kummel", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9925), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Dry Vermouth", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9652), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cherry", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9639), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Powdered sugar", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9597), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Blended whiskey", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9587), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sweet Vermouth", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9575), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Campari", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9567), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coca-Cola", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9556), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lemon", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9548), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Tequila", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9540), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Gin", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9531), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Vodka", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9519), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Water", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9509), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Angostura bitters", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9467), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Bourbon", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9458), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Soda water", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9412), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Mint", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9404), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sugar", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9395), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lime", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9382), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Light rum", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9044), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Olive", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9661), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Heavy cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(641), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Triple sec", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9676), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Salt", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9693), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Blackberry brandy", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9914), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Pineapple juice", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9899), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lemon vodka", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9889), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Brandy", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9877), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Nutmeg", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9867), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Light cream", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9859), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Creme de Cacao", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9850), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lemon peel", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9839), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Yellow Chartreuse", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9806), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orange bitters", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9796), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sloe gin", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9785), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Amaretto", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9774), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Southern Comfort", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9766), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lemon juice", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9757), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Apricot brandy", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9743), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ginger ale", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9734), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orange peel", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9722), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Maraschino cherry", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9714), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ice", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9706), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lime juice", new DateTime(2021, 4, 30, 12, 10, 17, 395, DateTimeKind.Utc).AddTicks(9684), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coconut syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2061), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Galliano", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(662), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Peach brandy", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(693), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Baileys irish cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1702), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ouzo", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1694), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sirup of roses", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1684), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Peach Vodka", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1674), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cranberry juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1660), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Peach schnapps", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1651), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Absolut Citron", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1638), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Espresso", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1624), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "J�germeister", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1713), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Marshmallows", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1605), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Vanilla extract", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1588), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Butter", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1579), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Vanilla", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1566), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cinnamon", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1551), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Chocolate", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1542), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cornstarch", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1530), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cocoa powder", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1521), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Papaya", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1467), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Half-and-half", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1597), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coffee", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1724), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Grain alcohol", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1733), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Spiced rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1795), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cranberries", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2013), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Caramel coloring", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(2003), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Marjoram leaves", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1983), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Falernum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4813), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Almond", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1964), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Angelica root", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1955), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Glycerine", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1946), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Food coloring", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1936), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Almond flavoring", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1926), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Apricot", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1917), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Wormwood", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1907), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Licorice root", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1898), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Anise", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1890), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Condensed milk", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1878), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Whipping cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1863), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coriander", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1853), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Black pepper", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1837), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cloves", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1828), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cardamom", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1819), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Kiwi", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1459), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Grapes", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1449), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Berries", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1439), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cantaloupe", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1425), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Anisette", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1026), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Curacao", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1009), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Peychaud bitters", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(994), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ricard", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(984), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lime peel", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(961), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "151 proof rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(951), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Milk", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(940), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(927), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lemon-lime soda", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(903), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lime vodka", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(885), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Coffee brandy", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(854), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sherry", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(844), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Raspberry syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(833), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Red wine", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(800), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Grapefruit juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(788), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Orgeat syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(766), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Drambuie", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(745), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Green Chartreuse", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(720), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Sweet and sour", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(702), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cointreau", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1044), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Irish whiskey", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(684), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Strawberry schnapps", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1069), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Maple syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1117), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Aperol", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1416), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cayenne pepper", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1402), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Ginger", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1392), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Mango", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1379), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Asafoetida", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1361), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cumin seed", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1349), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Mint syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1305), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Fruit", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1294), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Fruit juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1283), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Apple", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1273), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Chocolate syrup", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1258), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Honey", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1246), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Yoghurt", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1236), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Passion fruit juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1217), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Carrot", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1207), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Apple juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1199), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Cream", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1188), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Grape juice", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1146), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Creme de Cassis", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1127), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Anis", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(1100), null });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Name", "CreatedAt", "UpdatedAt" },
                values: new object[] { "blackstrap rum", new DateTime(2021, 4, 30, 12, 10, 17, 396, DateTimeKind.Utc).AddTicks(4844), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}

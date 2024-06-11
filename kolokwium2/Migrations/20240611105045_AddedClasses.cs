using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kolokwium2.Migrations
{
    /// <inheritdoc />
    public partial class AddedClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "backpackscharacters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    BackpacksCharacterId = table.Column<int>(type: "int", nullable: false),
                    BackpacksItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_backpackscharacters", x => new { x.CharacterId, x.BackpacksCharacterId, x.BackpacksItemId });
                    table.ForeignKey(
                        name: "FK_backpackscharacters_Backpacks_BackpacksCharacterId_BackpacksItemId",
                        columns: x => new { x.BackpacksCharacterId, x.BackpacksItemId },
                        principalTable: "Backpacks",
                        principalColumns: new[] { "CharacterId", "ItemId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_backpackscharacters_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "backpacksitems",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    BackpacksCharacterId = table.Column<int>(type: "int", nullable: false),
                    BackpacksItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_backpacksitems", x => new { x.ItemsId, x.BackpacksCharacterId, x.BackpacksItemId });
                    table.ForeignKey(
                        name: "FK_backpacksitems_Backpacks_BackpacksCharacterId_BackpacksItemId",
                        columns: x => new { x.BackpacksCharacterId, x.BackpacksItemId },
                        principalTable: "Backpacks",
                        principalColumns: new[] { "CharacterId", "ItemId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_backpacksitems_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "character_titlescharacters",
                columns: table => new
                {
                    CharactersId = table.Column<int>(type: "int", nullable: false),
                    CharacterTitlesCharacterId = table.Column<int>(type: "int", nullable: false),
                    CharacterTitlesTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_character_titlescharacters", x => new { x.CharactersId, x.CharacterTitlesCharacterId, x.CharacterTitlesTitleId });
                    table.ForeignKey(
                        name: "FK_character_titlescharacters_CharacterTitles_CharacterTitlesCharacterId_CharacterTitlesTitleId",
                        columns: x => new { x.CharacterTitlesCharacterId, x.CharacterTitlesTitleId },
                        principalTable: "CharacterTitles",
                        principalColumns: new[] { "CharacterId", "TitleId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_character_titlescharacters_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "character_titlestitles",
                columns: table => new
                {
                    TitlesId = table.Column<int>(type: "int", nullable: false),
                    CharacterTitlesCharacterId = table.Column<int>(type: "int", nullable: false),
                    CharacterTitlesTitleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_character_titlestitles", x => new { x.TitlesId, x.CharacterTitlesCharacterId, x.CharacterTitlesTitleId });
                    table.ForeignKey(
                        name: "FK_character_titlestitles_CharacterTitles_CharacterTitlesCharacterId_CharacterTitlesTitleId",
                        columns: x => new { x.CharacterTitlesCharacterId, x.CharacterTitlesTitleId },
                        principalTable: "CharacterTitles",
                        principalColumns: new[] { "CharacterId", "TitleId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_character_titlestitles_Titles_TitlesId",
                        column: x => x.TitlesId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_backpackscharacters_BackpacksCharacterId_BackpacksItemId",
                table: "backpackscharacters",
                columns: new[] { "BackpacksCharacterId", "BackpacksItemId" });

            migrationBuilder.CreateIndex(
                name: "IX_backpacksitems_BackpacksCharacterId_BackpacksItemId",
                table: "backpacksitems",
                columns: new[] { "BackpacksCharacterId", "BackpacksItemId" });

            migrationBuilder.CreateIndex(
                name: "IX_character_titlescharacters_CharacterTitlesCharacterId_CharacterTitlesTitleId",
                table: "character_titlescharacters",
                columns: new[] { "CharacterTitlesCharacterId", "CharacterTitlesTitleId" });

            migrationBuilder.CreateIndex(
                name: "IX_character_titlestitles_CharacterTitlesCharacterId_CharacterTitlesTitleId",
                table: "character_titlestitles",
                columns: new[] { "CharacterTitlesCharacterId", "CharacterTitlesTitleId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "backpackscharacters");

            migrationBuilder.DropTable(
                name: "backpacksitems");

            migrationBuilder.DropTable(
                name: "character_titlescharacters");

            migrationBuilder.DropTable(
                name: "character_titlestitles");
        }
    }
}

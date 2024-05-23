using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetCoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class Players : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerSkin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerSocialNetwork1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerSocialNetwork2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerSocialNetwork3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}

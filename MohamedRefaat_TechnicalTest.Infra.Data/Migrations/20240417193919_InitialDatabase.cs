using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MohamedRefaat_TechnicalTest.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appearances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eye_color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hair_color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appearances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appearances_Superheros_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Biographies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alter_egos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aliases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place_of_birth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    First_appearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alignment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biographies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Biographies_Superheros_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupAffiliation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relatives = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Connections_Superheros_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Superheros_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PowerStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intelligence = table.Column<int>(type: "int", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    Durability = table.Column<int>(type: "int", nullable: false),
                    Power = table.Column<int>(type: "int", nullable: false),
                    Combat = table.Column<int>(type: "int", nullable: false),
                    SuperheroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowerStats_Superheros_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Base = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_Superheros_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appearances_SuperheroId",
                table: "Appearances",
                column: "SuperheroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Biographies_SuperheroId",
                table: "Biographies",
                column: "SuperheroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Connections_SuperheroId",
                table: "Connections",
                column: "SuperheroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_SuperheroId",
                table: "Images",
                column: "SuperheroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PowerStats_SuperheroId",
                table: "PowerStats",
                column: "SuperheroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Works_SuperheroId",
                table: "Works",
                column: "SuperheroId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appearances");

            migrationBuilder.DropTable(
                name: "Biographies");

            migrationBuilder.DropTable(
                name: "Connections");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "PowerStats");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Superheros");
        }
    }
}

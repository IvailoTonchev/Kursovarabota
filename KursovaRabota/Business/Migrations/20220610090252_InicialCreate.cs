using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KursovaRabota.Migrations
{
    public partial class InicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roomid = table.Column<int>(type: "int", nullable: false),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rooms = table.Column<int>(type: "int", nullable: false),
                    People = table.Column<int>(type: "int", nullable: false),
                    Nights = table.Column<int>(type: "int", nullable: false),
                    Payment = table.Column<double>(type: "float", nullable: false),
                    Came = table.Column<double>(type: "float", nullable: false),
                    Gotout = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pricefor18orolders = table.Column<double>(type: "float", nullable: false),
                    Priceforunder18years = table.Column<double>(type: "float", nullable: false),
                    Priceforover60years = table.Column<double>(type: "float", nullable: false),
                    Freerooms = table.Column<int>(type: "int", nullable: false),
                    Cleaners = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}

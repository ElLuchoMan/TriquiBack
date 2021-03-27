using Microsoft.EntityFrameworkCore.Migrations;

namespace registro.Migrations
{
    public partial class V10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registro",
                columns: table => new
                {
                    Password = table.Column<string>(type: "varchar(10) CHARACTER SET utf8mb4", maxLength: 10, nullable: false),
                    Correo = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Apellido = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    TipoDocumento = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Documento = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro", x => new { x.Password, x.Correo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registro");
        }
    }
}

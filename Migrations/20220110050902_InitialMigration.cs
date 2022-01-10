using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GEN_InventarioRestApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medidas",
                columns: table => new
                {
                    MEDI_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MEDI_cTipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MEDI_cDescripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medidas", x => x.MEDI_Id);
                });

            migrationBuilder.CreateTable(
                name: "Secciones",
                columns: table => new
                {
                    SECC_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SECC_cDescripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secciones", x => x.SECC_Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    PROD_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROD_cDescripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PROD_nPrecio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PROD_nStock = table.Column<int>(type: "int", nullable: false),
                    MEDI_Id = table.Column<int>(type: "int", nullable: false),
                    SECC_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.PROD_Id);
                    table.ForeignKey(
                        name: "FK_Productos_Medidas_MEDI_Id",
                        column: x => x.MEDI_Id,
                        principalTable: "Medidas",
                        principalColumn: "MEDI_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Secciones_SECC_Id",
                        column: x => x.SECC_Id,
                        principalTable: "Secciones",
                        principalColumn: "SECC_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_MEDI_Id",
                table: "Productos",
                column: "MEDI_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_SECC_Id",
                table: "Productos",
                column: "SECC_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Medidas");

            migrationBuilder.DropTable(
                name: "Secciones");
        }
    }
}

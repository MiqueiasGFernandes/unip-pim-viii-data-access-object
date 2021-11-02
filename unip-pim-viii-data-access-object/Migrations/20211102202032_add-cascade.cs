using Microsoft.EntityFrameworkCore.Migrations;

namespace unip_pim_viii_data_access_object.Migrations
{
    public partial class addcascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cep = table.Column<int>(type: "int", nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TipoTelefones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTelefones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<long>(type: "bigint", nullable: false),
                    enderecoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Enderecos_enderecoid",
                        column: x => x.enderecoid,
                        principalTable: "Enderecos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoid = table.Column<int>(type: "int", nullable: true),
                    pessoaid = table.Column<int>(type: "int", nullable: false),
                    ddd = table.Column<int>(type: "int", nullable: false),
                    telefone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_pessoaid",
                        column: x => x.pessoaid,
                        principalTable: "Pessoas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Telefones_TipoTelefones_tipoid",
                        column: x => x.tipoid,
                        principalTable: "TipoTelefones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_enderecoid",
                table: "Pessoas",
                column: "enderecoid");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_pessoaid",
                table: "Telefones",
                column: "pessoaid");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_tipoid",
                table: "Telefones",
                column: "tipoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "TipoTelefones");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}

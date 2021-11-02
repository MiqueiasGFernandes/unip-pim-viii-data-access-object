using Microsoft.EntityFrameworkCore.Migrations;

namespace unip_pim_viii_data_access_object.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telefones");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoTelefones",
                table: "TipoTelefones");

            migrationBuilder.RenameTable(
                name: "TipoTelefones",
                newName: "BaseModel");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Pessoaid",
                table: "BaseModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bairro",
                table: "BaseModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cep",
                table: "BaseModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cidade",
                table: "BaseModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "cpf",
                table: "BaseModel",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ddd",
                table: "BaseModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "enderecoid",
                table: "BaseModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "estado",
                table: "BaseModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "logradouro",
                table: "BaseModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "BaseModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "numero",
                table: "BaseModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "telefone",
                table: "BaseModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipoid",
                table: "BaseModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseModel",
                table: "BaseModel",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_enderecoid",
                table: "BaseModel",
                column: "enderecoid");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_Pessoaid",
                table: "BaseModel",
                column: "Pessoaid");

            migrationBuilder.CreateIndex(
                name: "IX_BaseModel_tipoid",
                table: "BaseModel",
                column: "tipoid");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_enderecoid",
                table: "BaseModel",
                column: "enderecoid",
                principalTable: "BaseModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_Pessoaid",
                table: "BaseModel",
                column: "Pessoaid",
                principalTable: "BaseModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseModel_BaseModel_tipoid",
                table: "BaseModel",
                column: "tipoid",
                principalTable: "BaseModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_enderecoid",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_Pessoaid",
                table: "BaseModel");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseModel_BaseModel_tipoid",
                table: "BaseModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseModel",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_enderecoid",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_Pessoaid",
                table: "BaseModel");

            migrationBuilder.DropIndex(
                name: "IX_BaseModel_tipoid",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "Pessoaid",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "bairro",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "cep",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "cidade",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "cpf",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "ddd",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "enderecoid",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "logradouro",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "nome",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "numero",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "telefone",
                table: "BaseModel");

            migrationBuilder.DropColumn(
                name: "tipoid",
                table: "BaseModel");

            migrationBuilder.RenameTable(
                name: "BaseModel",
                newName: "TipoTelefones");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoTelefones",
                table: "TipoTelefones",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cep = table.Column<int>(type: "int", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpf = table.Column<long>(type: "bigint", nullable: false),
                    enderecoid = table.Column<int>(type: "int", nullable: true),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Enderecos_enderecoid",
                        column: x => x.enderecoid,
                        principalTable: "Enderecos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pessoaid = table.Column<int>(type: "int", nullable: true),
                    ddd = table.Column<int>(type: "int", nullable: false),
                    telefone = table.Column<int>(type: "int", nullable: false),
                    tipoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Telefones_Pessoas_Pessoaid",
                        column: x => x.Pessoaid,
                        principalTable: "Pessoas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Telefones_TipoTelefones_tipoid",
                        column: x => x.tipoid,
                        principalTable: "TipoTelefones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_enderecoid",
                table: "Pessoas",
                column: "enderecoid");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_Pessoaid",
                table: "Telefones",
                column: "Pessoaid");

            migrationBuilder.CreateIndex(
                name: "IX_Telefones_tipoid",
                table: "Telefones",
                column: "tipoid");
        }
    }
}

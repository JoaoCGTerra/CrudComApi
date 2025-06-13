using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzariaApi.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_cadastro_cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    email_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    rua_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    numero_rua_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    cidade_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    estado_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    cep_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    hash_senha_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    is_admin = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cadastro_cliente", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_cadastro_cliente");
        }
    }
}

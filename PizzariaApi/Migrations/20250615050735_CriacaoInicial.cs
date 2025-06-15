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
                name: "Tb_bebida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome_bebida = table.Column<string>(type: "TEXT", nullable: false),
                    Valor_bebida = table.Column<float>(type: "REAL", nullable: false),
                    Descricao_bebida = table.Column<string>(type: "TEXT", nullable: false),
                    Is_alcoolica = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_bebida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    Email_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    Rua_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    Numero_rua_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    Cidade_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    Estado_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    Cep_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    Hash_senha_cliente = table.Column<string>(type: "TEXT", nullable: false),
                    Is_admin = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_filiais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome_filial = table.Column<string>(type: "TEXT", nullable: false),
                    Endereco_Filial = table.Column<string>(type: "TEXT", nullable: false),
                    Telefone_Filial = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao_filial = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_filiais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_pizza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome_pizza = table.Column<string>(type: "TEXT", nullable: false),
                    Valor_pizza = table.Column<float>(type: "REAL", nullable: false),
                    Descricao_pizza = table.Column<string>(type: "TEXT", nullable: false),
                    Is_salgada = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_pizza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_sobremesa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome_sobremesa = table.Column<string>(type: "TEXT", nullable: false),
                    Valor_sobremesa = table.Column<float>(type: "REAL", nullable: false),
                    Rua_cliente = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_sobremesa", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_bebida");

            migrationBuilder.DropTable(
                name: "Tb_cliente");

            migrationBuilder.DropTable(
                name: "Tb_filiais");

            migrationBuilder.DropTable(
                name: "Tb_pizza");

            migrationBuilder.DropTable(
                name: "Tb_sobremesa");
        }
    }
}

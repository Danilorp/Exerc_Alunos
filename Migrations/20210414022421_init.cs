using Microsoft.EntityFrameworkCore.Migrations;

namespace Exerc_Alunos.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alunos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    materia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alunos", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "alunos",
                columns: new[] { "id", "Nome", "cpf", "endereco", "materia", "telefone" },
                values: new object[,]
                {
                    { 1, "Danilo", "12345678996", "rua Cesario", "Historia", "1696546578" },
                    { 2, "Luiz", "32566456666", "rua amador bueno", "Geografia", "169999854" },
                    { 3, "Andre", "11112525664", "rua luz", "Educação Fisica", "1696546578" },
                    { 4, "Luiz Careca", "5556678996", "rua senador", "Filosofia", "1696546578" },
                    { 5, "Daniel", "02525678996", "rua chile", "portugues", "1696546578" },
                    { 6, "Rafael", "6666545678996", "rua portugal", "ciencia", "1696546578" },
                    { 7, "Diogo", "125555678996", "rua Brasil", "portugues", "1696546578" },
                    { 8, "Sergio", "652345678996", "rua valentina", "geografia", "1696546578" },
                    { 9, "Joao", "45679998996", "rua cerqueira cesar", "matematica", "1696546578" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alunos");
        }
    }
}

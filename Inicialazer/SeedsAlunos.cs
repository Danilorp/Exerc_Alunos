using Exerc_Alunos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc_Alunos.Inicialazer
{
    public class SeedsAlunos: IEntityTypeConfiguration<Aluno>
    {

        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasData(
                new Aluno { id = 1, Nome = "Danilo", cpf = "12345678996", endereco = "rua Cesario", materia = "Historia", telefone = "1696546578" },
                new Aluno { id = 2, Nome = "Luiz",   cpf = "32566456666", endereco = "rua amador bueno", materia = "Geografia", telefone = "169999854" },
                new Aluno { id = 3, Nome = "Andre", cpf =  "11112525664", endereco = "rua luz", materia = "Educação Fisica", telefone = "1696546578" },
                new Aluno { id = 4, Nome = "Luiz Careca", cpf = "5556678996", endereco = "rua senador", materia = "Filosofia", telefone = "1696546578" },
                new Aluno { id = 5, Nome = "Daniel", cpf = "02525678996", endereco = "rua chile", materia = "portugues", telefone = "1696546578" },
                new Aluno { id = 6, Nome = "Rafael", cpf = "6666545678996", endereco = "rua portugal", materia = "ciencia", telefone = "1696546578" },
                new Aluno { id = 7, Nome = "Diogo", cpf = "125555678996", endereco = "rua Brasil", materia = "portugues", telefone = "1696546578" },
                new Aluno { id = 8, Nome = "Sergio", cpf = "652345678996", endereco = "rua valentina", materia = "geografia", telefone = "1696546578" },
                new Aluno { id = 9, Nome = "Joao", cpf = "45679998996", endereco = "rua cerqueira cesar", materia = "matematica", telefone = "1696546578" }
                );
        }
    }
}

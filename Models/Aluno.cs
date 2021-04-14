using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc_Alunos.Models
{
    [Table("alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Nome:")]
        public string Nome { get; set; }


        [Display(Name = "Endereço")]
        public string endereco { get; set; }


        [Display(Name = "cpf")]
        public string cpf { get; set; }


        [Display(Name = "telefone")]
        public string telefone { get; set; }


        [Display(Name = "Materia:")]
        public string materia { get; set; }









    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    [Table("Alunos")]
    public class Alunos
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Column("Nome")]
        [Display(Name = "Nome do Aluno")]
        public string Nome { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "CPF do Aluno")]
        public string Cpf { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "Email do Aluno")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do Aluno")]
        public string Telefone { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de Nascimento do Aluno")]
        public string DataNascimento { get; set; } = string.Empty;
    }
}

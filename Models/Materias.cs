using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {

        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Column("Titulo")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [ForeignKey("ProfessoresId")]
        [Display(Name = "Código do Professor")]
        public int ProfessoresId { get; set; }
        public Professores? Professores { get; set; }
    }
}

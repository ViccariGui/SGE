using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Etapas")]
    public class Etapas
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Column("Titulo")]
        [Display(Name = "Título da Etapa")]
        public string Titulo { get; set; } = string.Empty;

        [Column("Ano")]
        [Display(Name = "Ano")]
        public int Ano { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CEDPAPI.Models
{
    [Table("Cursos")]
    public class CourseEntity
    {
        public int Id { get; set; }

        [StringLength(150)] 
        [Column("Nome do Curso")]
        public string Name { get; set; }

        [StringLength(255)]
        [Column("Requisitos")]
        public string? Requisite { get; set; }

        [StringLength(150)]
        [Column("Carga Horária")]
        public int? Workload { get; set; }

        [Column("Valor")]
        public decimal Value { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace CEDPAPI.Models
{
    [Table("Turmos")]
    public class GradeEntity
    {
        [Column("Id do Estudante")]
        public int Id { get; set; }

        [ForeignKey("InstructorEntity")]
        [Column("Id do Instrutor")]
        public int IdInstructor { get; set; }

        [ForeignKey("CourseEntity")]
        [Column("Id do Curso")] 
        public int IdCourse { get; set; }

        [Column("Data de Início")]
        public DateTime? StartDate { get; set; }

        [Column("Data de Término")]
        public DateTime? EndDate { get; set; }

        [Column("Carga Horária")]
        public int? Workload { get; set; }

        public InstructorEntity InstructorEntity { get; set; }

        public CourseEntity CourseEntity { get; set; }
    }
}

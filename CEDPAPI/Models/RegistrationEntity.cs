using System.ComponentModel.DataAnnotations.Schema;

namespace CEDPAPI.Models
{
    [Table("Matrículas")]
    public class RegistrationEntity
    {
        [Column("Id da Matrícula")]
        public int Id { get; set; }
        
        [Column("Id da Turma")]
        public int IdGrade { get; set; }
        
        [Column("Id do Estudante")]
        public int IdStudent { get; set; }
        
        [Column("Data de Matrícula")]
        public DateOnly? RegisterDate { get; set; }
    }
}

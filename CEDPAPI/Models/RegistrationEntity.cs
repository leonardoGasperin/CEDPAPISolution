using System.ComponentModel.DataAnnotations.Schema;

namespace CEDPAPI.Models
{
    [Table("Matrículas")]
    public class RegistrationEntity
    {
        public int Id { get; set; }
        
        [Column("Id da Turma")]
        public int IdGrade { get; set; }
        
        [Column("Id do Estudante")]
        public int IdStudent { get; set; }
        
        [Column("Data de Matrícula")]
        public DateTime? RegisterDate { get; set; }
    }
}

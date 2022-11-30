using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CEDPAPI.Models
{
    [Table("Alunos")]
    public class StudentEntity
    {
        [Column("Id")]
        public int Id { get; set; }
        [StringLength(15), Column("CPF")]
        public string Cpf { get; set; }
        [StringLength(150), Column("Cliente")]
        public string Name { get; set; }
        [StringLength(50), Column("E-mail")]
        public string Email { get; set; }
        [StringLength(14), Column("Telefone")]
        public string Phone { get; set; }
        [Column("Data de nascimento")]
        public DateOnly? Birthdate { get; set; }
    }
}

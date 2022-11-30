using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CEDPAPI.Models
{
    [Table("Instrutores")]
    public class InstructorEntity
    {
        [Column("Id do Instrutor")]
        public int Id { get; set; }
        
        [StringLength(150)]
        [Column("Nome")] 
        public string Name { get; set; }
        
        [StringLength(150)]
        [Column("E-mail")] 
        public string Email { get; set; }
        
        [StringLength(50)]
        [Column("Telefone")] 
        public string Phone { get; set; }
        
        [Column("Valor por hora")]
        public decimal CostTime { get; set; }
        
        [StringLength(255)]
        [Column("Certificados")] 
        public string Certificate { get; set; }
    }
}

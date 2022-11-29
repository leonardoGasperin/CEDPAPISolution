using System.ComponentModel.DataAnnotations;

namespace CEDPAPI.Model
{
    public class StudentEntity
    {
        public int Id { get; set; }
        [StringLength(15)] public string Cpf { get; set; }
        [StringLength(150)] public string Name { get; set; }
        [StringLength(50)] public string Email { get; set; }
        [StringLength(14)] public string Phone { get; set; }
        public DateOnly? Birthdate { get; set; }
    }
}

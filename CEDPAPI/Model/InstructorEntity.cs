using System.ComponentModel.DataAnnotations;

namespace CEDPAPI.Model
{
    public class InstructorEntity
    {
        public int Id { get; set; }
        [StringLength(150)] public string Name { get; set; }
        [StringLength(150)] public string Email { get; set; }
        [StringLength(50)] public string Phone { get; set; }
        public decimal CostTime { get; set; }
        [StringLength(255)] public string Certificate { get; set; }
    }
}

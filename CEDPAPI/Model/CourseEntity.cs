using System.ComponentModel.DataAnnotations;

namespace CEDPAPI.Model
{
    public class CourseEntity
    {
        public int Id { get; set; }
        [StringLength(150)] public string Name { get; set; }
        [StringLength(255)] public string? Requisite { get; set; }
        [StringLength(150)] public int? Workload { get; set; }
        public decimal Value { get; set; }
    }
}

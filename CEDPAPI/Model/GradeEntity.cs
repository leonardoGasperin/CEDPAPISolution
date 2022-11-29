using System.ComponentModel.DataAnnotations.Schema;

namespace CEDPAPI.Model
{
    public class GradeEntity
    {
        public int Id { get; set; }
        [ForeignKey("InstructorEntity")] public int IdInstructor { get; set; }
        [ForeignKey("CourseEntity")] public int IdCourse { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Workload { get; set; }
        public InstructorEntity InstructorEntity { get; set; }
        public CourseEntity CourseEntity { get; set; }
    }
}

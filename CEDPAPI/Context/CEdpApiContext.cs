using CEDPAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CEDPAPI.Context
{
    public class CEdpApiContext : DbContext
    {
        public CEdpApiContext(DbContextOptions<CEdpApiContext> options) : base(options)
        {
        }

        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<InstructorEntity> Instructors { get; set; }
        public DbSet<RegistrationEntity> Registrations { get; set; }
        public DbSet<GradeEntity> Grades { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
    }
}

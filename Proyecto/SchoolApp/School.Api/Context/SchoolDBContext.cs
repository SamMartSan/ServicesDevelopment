using Microsoft.EntityFrameworkCore;
using School.Entities;

namespace School.Api.Context
{
    public partial class SchoolDBContext: DbContext
    {
        public SchoolDBContext()
        {
        }

        public SchoolDBContext(DbContextOptions<SchoolDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Courses> Courses { get; set; } = null!;
        public virtual DbSet<CoursesStudent> CoursesStudents { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

    }
}

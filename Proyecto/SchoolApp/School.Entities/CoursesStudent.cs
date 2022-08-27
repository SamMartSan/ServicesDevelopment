using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class CoursesStudent
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public byte Grade { get; set; }

        public virtual Student Student { get; set; } = null!;
    }
}

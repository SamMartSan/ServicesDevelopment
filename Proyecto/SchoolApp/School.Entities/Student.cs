using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Student
    {

        public Student()
        {
            CoursesStudents = new HashSet<CoursesStudent>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public char Sex { get; set; } = null!;

        public virtual ICollection<CoursesStudent> CoursesStudents { get; set; }

    }
}

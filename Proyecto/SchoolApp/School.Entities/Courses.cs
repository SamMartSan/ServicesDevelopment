using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Courses
    {
        public int Id { get; set; }
        public string Description  { get; set; }    
          
        public int HoursByWeek { get; set; }
        public int Grade { get; set; }
    }
}

using EmployeeApp.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Domain.Entities
{
<<<<<<< HEAD
    public class Employee : EntityBase
    {


        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime HireDate { get; set; }
        [Required]

        [RegularExpression("IT|Finance|Audit", ErrorMessage = "Invalid Department")]
        public string Department { get; set; }
    }
=======
   public class Employee : EntityBase
   {
      [Required]
      public string? FirstName { get; set; }

      [Required]
      public string? LastName { get; set; }

      public DateTime HireDate { get; set; }

      [Required]
      public string? Department { get; set; }
   }
>>>>>>> main
}
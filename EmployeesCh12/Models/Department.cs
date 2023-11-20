using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EmployeesCh12.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Department")]
        public string Name { get; set; } = string.Empty;

        //Navi Properties
        public ICollection<Employee> Employees { get; set; }= new HashSet<Employee>();

        //Navi Properties
        public ICollection<DepartmentLocation> DepartmentLoctions { get; set; } = new HashSet<DepartmentLocation>();
    }
}
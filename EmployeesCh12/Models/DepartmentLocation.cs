namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //Composite Primary Key/Foreign key for Department
        public int DepartmentID { get; set; }
        //Composition Primary/Foreign key for location
        public int LocationID {  get; set; }

        //navi properties
        public Department Department { get; set; } = null;
        public Location Location { get; set; } = null;
    }
}

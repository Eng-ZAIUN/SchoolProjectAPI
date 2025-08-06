
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.Entities;

public partial class Departments
{
    public Departments()
    {
        Students = new HashSet<Students>();
        DepartmentSubject = new HashSet<DepartmentsSubject>();

    }

    [Key]
    public int DID { get; set; }

    [StringLength(100)]
    public string? DName { get; set; }


    public virtual ICollection<Students> Students { get; set; }
    public virtual ICollection<DepartmentsSubject> DepartmentSubject { get; set; }
}

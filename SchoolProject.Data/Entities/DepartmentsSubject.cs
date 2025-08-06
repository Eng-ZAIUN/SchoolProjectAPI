
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities;

public class DepartmentsSubject
{
    [Key]
    public int DeptSubID { get; set; }

    public int DID { get; set; }
    public int SubID { get; set; }


    [ForeignKey("DID")]
    public virtual Departments? Department { get; set; }

    [ForeignKey("SubID")]
    public virtual Subjects? Subject { get; set; }
}

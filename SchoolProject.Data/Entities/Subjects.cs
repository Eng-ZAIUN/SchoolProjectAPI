
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data.Entities;

public class Subjects
{
    public Subjects()
    {
        StudentSubjects = new HashSet<StudentSubject>();
        DepartmentsSubject = new HashSet<DepartmentsSubject>();
    }

    [Key]
    public int SubID { get; set; }

    [StringLength(100)]
    public string? SubjectName { get; set; }

    public DateTime Period { get; set; }

    public virtual ICollection<StudentSubject> StudentSubjects { get; set; }

    public virtual ICollection<DepartmentsSubject> DepartmentsSubject { get; set; }
}

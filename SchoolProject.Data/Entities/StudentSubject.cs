
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities;

public class StudentSubject
{
    [Key]
    public int StudSubID { get; set; }

    public int StudID { get; set; }
    public int SubID { get; set; }


    [ForeignKey("StudID")]
    public virtual Students? Student { get; set; }

    [ForeignKey("SubID")]
    public virtual Subjects? Subject { get; set; }
}

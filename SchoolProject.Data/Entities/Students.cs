
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Data.Entities;

public class Students
{
    [Key]
    public int StudID { get; set; }
    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(200)]
    public string? Address { get; set; }

    [StringLength(50)]
    public string? Phone { get; set; }

    public int DID { get; set; }

    [ForeignKey("DID")]
    public virtual Departments? Department { get; set; }
}

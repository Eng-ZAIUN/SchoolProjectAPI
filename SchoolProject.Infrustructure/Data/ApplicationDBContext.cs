
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;

namespace SchoolProject.Infrustructure.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext() {}
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options) {}

    public DbSet<Students> Students { get; set;}
    public DbSet<Departments> Departments { get; set;}
    public DbSet<Subjects> Subjects { get; set;}
    public DbSet<DepartmentsSubject> DepartmentsSubjects { get; set;}
    public DbSet<StudentSubject> StudentsSubjects { get; set;}
}
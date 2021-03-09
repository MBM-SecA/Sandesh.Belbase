using StudentsApi.Models;
using Microsoft.EntityFrameworkCore;
namespace StudentsApi.Data{
    public class StudentContext:DbContext{
        public StudentContext(DbContextOptions<StudentContext> Options):base(Options){}
        public DbSet<Student> Students { get; set; }
    }
}
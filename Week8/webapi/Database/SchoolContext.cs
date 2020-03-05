using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Database
{
    public class SchoolContext : Microsoft.EntityFrameworkCore.DbContext
	{
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)         
        {         
        }
        
        public Microsoft.EntityFrameworkCore.DbSet<Student> Student { get; set; }
    }
}
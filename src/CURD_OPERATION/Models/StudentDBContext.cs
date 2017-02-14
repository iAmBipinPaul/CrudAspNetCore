using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CURD_OPERATION.Models
{
    public class StudentDBContext : DbContext
    {

        public StudentDBContext(DbContextOptions<StudentDBContext> options)

            : base(options)

        { }
        public DbSet<Student> Students { get; set; }
    }
        
}

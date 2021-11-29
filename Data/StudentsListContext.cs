using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentsList.Models;

namespace StudentsList.Data
{
    public class StudentsListContext : DbContext
    {
        public StudentsListContext (DbContextOptions<StudentsListContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsList.Models.Student> Student { get; set; }
    }
}

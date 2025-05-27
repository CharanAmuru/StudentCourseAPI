using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentCourseAPI.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentCourseAPI.Models.Course> Course { get; set; } = default!;

public DbSet<StudentCourseAPI.Models.Student> Student { get; set; } = default!;
    }

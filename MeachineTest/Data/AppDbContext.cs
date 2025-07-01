using MeachineTest.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MeachineTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}

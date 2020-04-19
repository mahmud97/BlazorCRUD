using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GridSample.Data
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options):
            base(options)
        {

        }

        public DbSet<TestList> TestLists { get; set; }
        public DbSet<TestListDetails> TestListDetails { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCRUD.Shared.Models;
namespace BlazorCRUD.Server.Db
{
    public class MainDbContext : DbContext
    {

        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    var patient = new List<Patient>();
        //    for (int i = 6; i < 106; i++)
        //    {
        //        people.Add(new Person() { Id = i, Name = $"Person {i}" });
        //    }

        //    builder.Entity<Person>().HasData(people);

        //    base.OnModelCreating(builder);
        //}

        public DbSet<Patient> Patients { get; set; }

    }
}

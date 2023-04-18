using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16ex1.Models
{
    internal class StudentsDbContext : DbContext
    {
        public DbSet<Student> Students { get; set;}
        public DbSet<Specializare> Specializari { get; set;}

        public StudentsDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alexandra\\source\\repos\\Lab16ex1\\Lab16ex1\\StudentsDb.mdf;Integrated Security=True");
        }
    }
}

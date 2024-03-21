using Microsoft.EntityFrameworkCore;
using solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid.Data
{
    public class DataContext:DbContext
    {
      
        

        public DbSet<User> Users { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Job> Jobs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Employment_Office_db");
        }

        //public DataContext()
        //{
        //    Users = new DbSet<User>();
        //    Users.Add(new User() { Id = 1, Name = "name", Category = "category", Experience = 0 });
        //    Interviews = new DbSet<Interview>();
        //    Jobs=new DbSet<Job>();
        //}
    }
}

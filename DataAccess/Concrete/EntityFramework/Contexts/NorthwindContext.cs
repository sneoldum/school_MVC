using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;initial catalog=Students ;Trusted_Connection=True;ConnectRetryCount=0");
        
        }



        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }  
    }
}

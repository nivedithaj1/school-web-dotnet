using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using School3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School3.DB
{
    public class ApplicationDbContext:DbContext
    {
        // send the configuration which we give to base class DB context
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<StudentModel> StudentModel { get; set; }
    }
}

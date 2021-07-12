using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPractica.Entities;
using Microsoft.EntityFrameworkCore;
namespace AppPractica.Data
{
    public class MainDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public MainDbContext(DbContextOptions<MainDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }



    }

}



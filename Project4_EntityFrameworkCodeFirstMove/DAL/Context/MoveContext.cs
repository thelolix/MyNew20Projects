using Project4_EntityFrameworkCodeFirstMove.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFrameworkCodeFirstMove.DAL.Context
{
    public class MoveContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet <Category> Categories { get; set; }
    }
}

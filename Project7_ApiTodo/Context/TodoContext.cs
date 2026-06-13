using Microsoft.EntityFrameworkCore;
using Project7_ApiTodo.Entities;

namespace Project7_ApiTodo.Context
{
    public class TodoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Talha\\SQLEXPRESS;Initial Catalog=Db7Project20;Integrated Security=True;Trust Server Certificate=True;");
     
        }
    
        public DbSet<Todo>Todos{ get; set; }
    }
}

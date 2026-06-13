using Microsoft.EntityFrameworkCore;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Context
{
    public class WeatherContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("server=Talha\\SQLEXPRESS;Initial Catalog=Db6Project20;Integrated Security=True;Trust Server Certificate=True;");
        }

        public DbSet<City> Cities { get; set; }
    }
}
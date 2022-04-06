using System;
using CountryWeatherDataModel;
using Microsoft.EntityFrameworkCore;
namespace CountryWeatherDataRepository
{
    public class CityWeatherDbContext: DbContext
    {
        public CityWeatherDbContext(DbContextOptions<CityWeatherDbContext> opt) : base(opt)
        {

        }
        public DbSet<CityWeather> CityWeather { get; set; }
    }
}

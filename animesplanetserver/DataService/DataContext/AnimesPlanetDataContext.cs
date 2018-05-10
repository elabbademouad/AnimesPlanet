using Microsoft.EntityFrameworkCore;
namespace animesplanetserver.DataService.DataContext
{
    public class AnimesPlanetDataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source =./DataService/DataBase/DataBaseAnimesPlanet.db");
        }
    }
}
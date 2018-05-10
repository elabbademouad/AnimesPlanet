using Microsoft.EntityFrameworkCore;
using animesplanetserver.Model;
namespace animesplanetserver.DataService.DataContext
{
    public class AnimesPlanetDataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source =./DataService/DataBase/DataBaseAnimesPlanet.db");
        }

        public DbSet<Anime> Animes {get;set;}
        public DbSet<EpicMoment> EpicMoments {get;set;}
        public DbSet<Music> Musics {get;set;}
        public DbSet<Picture> Pictures {get;set;}
        public DbSet<Character> Characters {get;set;}
    }
}
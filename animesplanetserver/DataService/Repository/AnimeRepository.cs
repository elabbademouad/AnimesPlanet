using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using animesplanetserver.DataService.DataContext;
using animesplanetserver.Model;
namespace animesplanetserver.DataService.Repository
{
    public class AnimeRepository : IRepository<AnimesPlanetDataContext, Anime>
    {
        public AnimesPlanetDataContext Context { get ; set ; }

        public AnimeRepository()
        {
            this.Context=new AnimesPlanetDataContext();
        }
        public void Add(Anime entity)
        {
            Context.SaveChanges();
            Context.Animes.Add(entity);
        }

        public void AddRange(List<Anime> entitys)
        {
            Context.Animes.AddRange(entitys);
            Context.SaveChanges();            
        }

        public void Delete(Anime entity)
        {
            Context.Animes.Attach(entity);
            Context.Animes.Remove(entity);
            Context.SaveChanges();
        }

        public void DeleteRange(List<Anime> entitys)
        {
            Context.Animes.AttachRange(entitys);
            Context.RemoveRange(entitys);
            Context.SaveChanges();
        }

        public void DeleteWhere(Expression<Func<Anime, bool>> predicate)
        {
            var entitys=Context.Animes.Where(predicate);
            if(entitys!=null)
            {
                Context.Animes.RemoveRange(entitys);
                Context.SaveChanges();
            }
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }

        public void Edit(Anime entity)
        {
            
        }

        public void EditRange(List<Anime> entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Anime> GetAll()
        {
            return this.Context.Animes;
        }

        public IQueryable<Anime> GetWhere(Expression<Func<Anime, bool>> predicate)
        {
            return this.Context.Animes.Where(predicate);
        }
    }
}
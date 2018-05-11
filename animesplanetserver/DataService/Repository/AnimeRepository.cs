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

        public void Add(Anime entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(List<Anime> entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Anime entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<Anime> entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteWhere(Expression<Func<Anime, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Edit(Anime entity)
        {
            throw new NotImplementedException();
        }

        public void EditRange(List<Anime> entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Anime> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Anime> GetWhere(Expression<Func<Anime, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
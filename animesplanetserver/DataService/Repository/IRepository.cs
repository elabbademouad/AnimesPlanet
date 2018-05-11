using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace animesplanetserver.DataService.Repository
{
    public interface IRepository<C, TEntity> :IDisposable where TEntity : class where C : DbContext, new()
    {
        C Context { get; set; }
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(List<TEntity> entitys);
        void Delete(TEntity entity);
        void DeleteRange(List<TEntity> entitys);
        void DeleteWhere(Expression<Func<TEntity, bool>> predicate);
        void Edit(TEntity entity);
        void EditRange(List<TEntity> entitys);
    }
}
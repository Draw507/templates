using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facturacion.Repository.Contexts;
using Facturacion.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Facturacion.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected ApplicationDbContext _context { get; set; }

        public RepositoryBase(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return this._context.Set<TEntity>().AsQueryable();
        }

        public IQueryable<TEntity> GetAll()
        {
            return this._context.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> FindBy(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return this._context.Set<TEntity>().Where(predicate).AsNoTracking();
        }

        public TEntity GetById(int id)
        {
            return this._context.Set<TEntity>().Find(id);
        }

        public TEntity GetById(string id)
        {
            return this._context.Set<TEntity>().Find(id);
        }

        public TEntity GetById(long id)
        {
            return this._context.Set<TEntity>().Find(id);
        }

        public bool Exists(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return this._context.Set<TEntity>().Any(predicate);
        }

        public TEntity AddAndGetEntity(TEntity entity)
        {
            return this._context.Set<TEntity>().Add(entity).Entity;
        }

        public void Add(TEntity entity)
        {
            this._context.Set<TEntity>().Add(entity);
        }

        public void AddRange(List<TEntity> entity)
        {
            this._context.Set<TEntity>().AddRange(entity);
        }

        public void Delete(TEntity entity)
        {
            this._context.Set<TEntity>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entity)
        {
            this._context.Set<TEntity>().RemoveRange(entity);
        }

        public void Attach(TEntity entity)
        {
            this._context.Set<TEntity>().Attach(entity).State = EntityState.Modified;
        }

        public void Update(TEntity entity)
        {
            this._context.Set<TEntity>().Update(entity);
        }
    }
}

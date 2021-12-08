using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoModeloDDDContext context = new ProjetoModeloDDDContext();

        public void Add(TEntity obj)
        {
            context.Set<TEntity>().Add(obj);
            context.SaveChanges();
        }        

        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
        
        public void Update(TEntity obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            context.Set<TEntity>().Remove(obj);
            context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

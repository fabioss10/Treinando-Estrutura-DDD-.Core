using System;
using System.Linq;
using System.Linq.Expressions;
using EstruturaDDCore.Domain.Core.Interfaces.Repository;
using EstruturaDDDCore.DomainT.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstruturaDDD.infra.DataR.Repository
{
    public class Repository<T> : IRepository<T> where T: Entity

    {

        protected ModeloContexto Db;
        protected DbSet<T> DbSet;


        public Repository (ModeloContexto context)
        {
            Db = context;
        }


        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> where, params string[] include)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(params string[] include)
        {
            throw new NotImplementedException();
        }

        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public T GetById(string id)
        {
            throw new NotImplementedException();
        }

        public T GetById(object[] keys)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetMany(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetMany(Expression<Func<T, bool>> where, params string[] include)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public T GetSingle(Expression<Func<T, bool>> where, params string[] include)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

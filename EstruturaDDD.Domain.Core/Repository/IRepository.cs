
using EstruturaDDDCore.DomainT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EstruturaDDCore.Domain.Core.Interfaces.Repository
{
    public interface IRepository <T> : IDisposable where T: Entity
    {

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(long id);
        T GetById(string id);
        T GetById(object[] keys);
        T Get(Expression<Func<T, bool>> where);
        T Get(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include);
        T Get(Expression<Func<T, bool>> where, params string[] include);
        T GetSingle(Expression<Func<T, bool>> where);
        T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include);
        T GetSingle(Expression<Func<T, bool>> where, params string[] include);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] include);
        IQueryable<T> GetAll(params string[] include);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] include);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where, params string[] include);


    }
}

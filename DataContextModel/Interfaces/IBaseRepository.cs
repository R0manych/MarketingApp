using DataContextModel.Models;
using DataContextModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Add(T entity);

        void Delete(int id);

        void Edit(T entity);

        IQueryable<T> GetAll();

        T GetById(int id);

        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        void Dispose();
    }
}

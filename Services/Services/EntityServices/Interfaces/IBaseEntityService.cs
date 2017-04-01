using DataContextModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.EntityServices.Interfaces
{
    public interface IBaseEntityService<T> where T : BaseEntity
    {
        List<T> GetAll();

        void Add(T entity);

        void Delete(T entity);

        T GetById(int id);

        void Update(T entity);
    }
}

using DataContextModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Product GetByName(string name);
    }
}

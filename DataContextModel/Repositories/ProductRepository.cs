using DataContextModel.Interfaces;
using DataContextModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public Product GetByName(string name) => GetAll().Where(p => p.Name == name).FirstOrDefault();
    }
}

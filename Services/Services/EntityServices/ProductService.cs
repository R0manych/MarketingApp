using BusinessLogic.Services.EntityServices.Interfaces;
using DataContextModel.Interfaces;
using DataContextModel.Models;
using DataContextModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.EntityServices
{
    public class ProductService : IProductService
    {
        IProductRepository _products = new ProductRepository();

        public void Add(Product product)
        {
                try
                {
                    _products.Add(product);
                }
                catch
                {
                    throw;
                }
        }

        public void Delete(Product product)
        {
                try
                {
                    _products.Delete(product.Id);
                }
                catch
                {
                    throw;
                }
            
        }

        public List<Product> GetAll() => _products.GetAll().ToList();

        public Product GetById(int id) => _products.GetById(id);

        public void Update(Product product)
        {
            try
            {
                    _products.Edit(product);
            }
            catch
            {
                throw;
            }
        }

        public List<string> GetAllNames()
        {
            var products = _products.GetAll().ToList();
            List<string> names = new List<string>();
            foreach (var product in products)
            {
                names.Add(product.Name);
            }
            return names;
        }

        public decimal GetPriceByName(string name) => _products.GetByName(name).Price;

        public Product GetByName(string name)
        {
            return _products.GetAll().FirstOrDefault(p => p.Name == name);
        }
    }
}

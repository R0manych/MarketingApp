using DataContextModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.EntityServices.Interfaces
{
    public interface IProductService : IBaseEntityService<Product>
    {
        List<string> GetAllNames();

        decimal GetPriceByName(string name);

        Product GetByName(string name);
    }
}

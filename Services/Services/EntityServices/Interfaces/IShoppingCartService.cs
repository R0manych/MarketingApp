using DataContextModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.EntityServices.Interfaces
{
    public interface IShoppingCartService : IBaseEntityService<ShoppingCart>
    {
        decimal CountAllCost(int Id);

        int CountPoints(int Id);
    }
}

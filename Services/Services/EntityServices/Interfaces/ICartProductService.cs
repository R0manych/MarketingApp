using DataContextModel.Models;
using DataContextModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.EntityServices.Interfaces
{
    public interface ICartProductService : IBaseEntityService<CartProduct>
    {
        List<CartProductView> GetByCartId(int cartId);

        void Delete(int id);

        void SaveOrUpdate(List<CartProductView> products);

        CartProductView GetCartProductViewFromProduct(Product product);
    }


}

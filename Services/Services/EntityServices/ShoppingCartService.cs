using BusinessLogic.Services.EntityServices.Interfaces;
using DataContextModel.Models;
using DataContextModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.EntityServices
{
    public class ShoppingCartService : IShoppingCartService
    {
        public static int PointsValue{ get; set; }

        static ShoppingCartService()
        {
            PointsValue = 1;
        }

        public void Add(ShoppingCart shoppingCart)
        {
            using (var _shoppingCarts = new ShoppingCartRepository())
            {
                try
                {
                    _shoppingCarts.Add(shoppingCart);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            
        }

        public void Delete(ShoppingCart shoppingCart)
        {
            using (var _shoppingCarts = new ShoppingCartRepository())
            {
                try
                {
                    _shoppingCarts.Delete(shoppingCart.Id);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public List<ShoppingCart> GetAll()
        {
            using (var _shoppingCarts = new ShoppingCartRepository())
            {
                return _shoppingCarts.GetAll().ToList();
            }
        }

        public ShoppingCart GetById(int id)
        {
            using (var _shoppingCarts = new ShoppingCartRepository())
            {
                return _shoppingCarts.GetById(id);
            }
        }

        public void Update(ShoppingCart shoppingCart)
        {
            using (var _shoppingCarts = new ShoppingCartRepository())
            {
                try
                {
                    _shoppingCarts.Edit(shoppingCart);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public decimal CountAllCost(int Id)
        {
            using (var _shoppingCarts = new ShoppingCartRepository())
            {
                var cart = _shoppingCarts.GetById(Id);
                decimal sum = 0;
                foreach (var product in cart.Products)
                {
                    sum += product.Count * product.Product.Price;
                }
                return Math.Round(sum, 2);
            }
        }

        public int CountPoints(int id) => Convert.ToInt32(CountAllCost(id) * PointsValue);
    }
}

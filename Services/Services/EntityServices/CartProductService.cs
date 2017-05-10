using DataContextModel.Models;
using DataContextModel.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContextModel.ViewModels;
using DataContextModel.Interfaces;
using BusinessLogic.Services.EntityServices.Interfaces;

namespace BusinessLogic.Services.EntityServices
{
    public class CartProductService : ICartProductService
    {
        ICartProductRepository _cartProducts = new CartProductRepository();

        public void Add(CartProduct product)
        {
                try
                {
                    _cartProducts.Add(product);
                }
                catch 
                {
                    throw;
                }
            
        }

        public void Delete(CartProduct product)
        {
                try
                {
                    _cartProducts.Delete(product.Id);
                }
                catch
                {
                    throw;
                }
            
        }

        public void Delete(int id)
        {
            try
            {
                _cartProducts.Delete(id);
            }
            catch
            {
                throw;
            }
        }

        public List<CartProduct> GetAll() => _cartProducts.GetAll().ToList();

        public List<CartProductView> GetByCartId(int cartId)
        {
            var products = _cartProducts.GetAll().Where(p => p.CartId == cartId);
            var productsViewModel = new List<CartProductView>();
            foreach (var product in products)
            {
                productsViewModel.Add(new CartProductView(product.Product.Name, product.Id, cartId, Math.Round(product.Product.Price, 2))
                { Count = product.Count });
            }
            return productsViewModel;
        }

        public CartProduct GetById(int id) => _cartProducts.GetById(id);

        public void SaveOrUpdate(List<CartProductView> products)
        {
            foreach(var productView in products)
            {
                if (productView.Id == 0)
                    _cartProducts.Add(GetProductFromView(productView));
                else
                {
                    var product = _cartProducts.GetById(productView.Id);
                    product.Count = productView.Count;
                    _cartProducts.Edit(product);
                }
            }
        }

        private CartProduct GetProductFromView(CartProductView productView)
        {
            int prodId;
            using (var prodRep = new ProductRepository())
            {
                prodId = prodRep.GetByName(productView.ProductName).Id;
            }
            return new CartProduct()
            {
                Id = productView.Id,
                ProductId = prodId,
                Count = productView.Count,
                CartId = productView.CartId
            };
        }

        public CartProductView GetCartProductViewFromProduct(Product product) => new CartProductView(product.Name, 0, 0, product.Price);

        public void Update(CartProduct product)
        {
            try
            {
                    _cartProducts.Edit(product);
                
            }
            catch
            {
                throw;
            }
        }

    }
}


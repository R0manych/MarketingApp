using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services.EntityServices.Interfaces;
using BusinessLogic.Services.EntityServices;
using DataContextModel.ViewModels;

namespace Desktop.Forms.ShoppingCart
{
    public partial class AddShoppingCartForm : Form
    {
        int _cartId;

        ICartProductService _cartProductService;
        IProductService _productService;

        public AddShoppingCartForm()
        {
            InitializeComponent();
            _cartProductService = new CartProductService();
            _productService = new ProductService();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _cartProductService.SaveOrUpdate(dataGridCart.DataSource as List<CartProductView>);   
        }

        private void AddShoppingCartForm_Load(object sender, EventArgs e)
        {
            comboBoxProduct.DataSource = _productService.GetAllNames().ToArray();
            dataGridCart.DataSource = _cartProductService.GetByCartId(_cartId);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var product = _productService.GetByName(comboBoxProduct.SelectedText);
            ((IList<CartProductView>)dataGridCart.DataSource).Add(
                new CartProductView(product.Name, 0, _cartId, _productService.GetPriceByName(product.Name)));

        }
    }
}

using BusinessLogic.Services.EntityServices;
using BusinessLogic.Services.EntityServices.Interfaces;
using DataContextModel.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms.ShoppingCart
{
    public partial class EditShoppingCartForm : Form
    {
        private int _cartId;

        ICartProductService _cartProductService;
        IProductService _productService;

        public EditShoppingCartForm()
        {
            InitializeComponent();
            _cartProductService = new CartProductService();
            _productService = new ProductService();
        }

        public EditShoppingCartForm(int cartId)
        {
            InitializeComponent();
            _cartProductService = new CartProductService();
            _productService = new ProductService();
            _cartId = cartId;
        }

        private void EditShoppingCartForm_Load(object sender, EventArgs e)
        {
            comboBoxProduct.DataSource = _productService.GetAllNames().ToArray();
            dataGridCart.DataSource = _cartProductService.GetByCartId(_cartId);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var product = _productService.GetByName(comboBoxProduct.SelectedText);
            ((IList<CartProductView>)dataGridCart.DataSource).Add(
                new CartProductView(product.Name, 0, _cartId, _productService.GetPriceByName(product.Name)));
        }
    }
}

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
using Desktop.Forms.Common;
using DataContextModel.Models;

namespace Desktop.Forms.ShoppingCart
{
    public partial class AddShoppingCartForm : Form
    {
        ICartProductService _cartProductService = new CartProductService();
        IProductService _productService = new ProductService();
        IShoppingCartService _cartService = new ShoppingCartService();
        private int _clientId;
        private DataContextModel.Models.ShoppingCart _shoppingCart;
        private BindingList<CartProduct> _bindingListCart;

        public AddShoppingCartForm()
        {
            InitializeComponent();
        }

        public AddShoppingCartForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            var acceptForm = new AcceptForm("Закрыть без сохранения изменений?");
            acceptForm.ShowDialog();
            if (acceptForm.Accepted)
                Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //_cartProductService.SaveOrUpdate(dataGridCart.DataSource as List<CartProductView>);  
            try
            {
                _cartService.Add(_shoppingCart);
                MessageBox.Show("Покупки добавлены");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Покупки не были добавлены " + ex.Message);
            }
        }

        private void AddShoppingCartForm_Load(object sender, EventArgs e)
        {
            _shoppingCart = new DataContextModel.Models.ShoppingCart()
            {
                ClientId = _clientId,
                Date = DateTime.Now,
                Delivered = false,
                Number = "1"    
            };
            comboBoxProduct.DataSource = _productService.GetAllNames().ToArray();
            _bindingListCart = new BindingList<CartProductView>(_shoppingCart.Products.ToList());
            dataGridCart.DataSource = _bindingListCart;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var product = _productService.GetByName(comboBoxProduct.SelectedValue.ToString());
            _shoppingCart.Products.Add(_cartProductService.GetCartProductFromProduct(product));
            _bindingListCart = new BindingList<CartProductView>(_shoppingCart.Products.ToList());
            dataGridCart.DataSource = _bindingListCart;
        }
    }
}

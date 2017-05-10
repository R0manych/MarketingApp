using BusinessLogic.Services.EntityServices;
using BusinessLogic.Services.EntityServices.Interfaces;
using DataContextModel.ViewModels;
using Desktop.Forms.Common;
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
        ICartProductService _cartProductService = new CartProductService();
        IProductService _productService = new ProductService();
        IShoppingCartService _cartService = new ShoppingCartService();
        private BindingList<CartProductView> _bindingListCart;
 
        private DataContextModel.Models.ShoppingCart _shoppingCart;

        public EditShoppingCartForm()
        {
            InitializeComponent();

        }

        public EditShoppingCartForm(int cartId)
        {
            InitializeComponent();
            _shoppingCart = _cartService.GetById(cartId);
        }

        private void EditShoppingCartForm_Load(object sender, EventArgs e)
        {
            comboBoxProduct.DataSource = _productService.GetAllNames().ToArray();
            this.Text += " " + _shoppingCart.Number.ToString();
            checkBoxDelivered.Checked = _shoppingCart.Delivered;
            _bindingListCart = new BindingList<CartProductView>(_cartProductService.GetByCartId(_shoppingCart.Id));
            dataGridCart.DataSource = _bindingListCart;
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
            try
            {
                _cartProductService.SaveOrUpdate(_bindingListCart.ToList<CartProductView>());
                _cartService.Update(_shoppingCart);
                MessageBox.Show("Заказ изменен");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Покупки не были добавлены " + ex.Message);
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var product = _productService.GetByName(comboBoxProduct.SelectedValue.ToString());
            var cartProductView = _cartProductService.GetCartProductViewFromProduct(product);
            cartProductView.CartId = _shoppingCart.Id;
            _bindingListCart.Add(cartProductView);
        }

        private void checkBoxDelivered_CheckedChanged(object sender, EventArgs e)
        {
            _shoppingCart.Delivered = checkBoxDelivered.Checked;
        }
    }
}

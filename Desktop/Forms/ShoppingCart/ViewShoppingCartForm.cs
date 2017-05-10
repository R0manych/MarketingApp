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
using Desktop.Forms.Common;

namespace Desktop.Forms.ShoppingCart
{
    public partial class ViewShoppingCartForm : Form
    {
        int _cartId;
        ICartProductService _cartProductService = new CartProductService();
        IShoppingCartService _cartService = new ShoppingCartService();
        bool _isModified = false;

        public ViewShoppingCartForm()
        {
            InitializeComponent();
        }

        public ViewShoppingCartForm(int cartId)
        {
            InitializeComponent();
            _cartId = cartId;
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewShoppingCartForm_Load(object sender, EventArgs e)
        {
            var _shoppingCart = _cartService.GetById(_cartId);
            this.Text += " " + _shoppingCart.Number.ToString();
            Reload();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editForm = new EditShoppingCartForm(_cartId);
            editForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            dataGridCart.DataSource = _cartProductService.GetByCartId(_cartId);
        }   
    }
}

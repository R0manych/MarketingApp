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

        private void SaveData()
        {
            var cart = _cartService.GetById(_cartId);
            if (checkBoxDelivered.Checked != cart.Delivered)
            {
                cart.Delivered = checkBoxDelivered.Checked;
                _cartService.Update(cart);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void ViewShoppingCartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isModified)
            {
                var acceptForm = new AcceptForm("Закрыть без сохранения изменений?");
                acceptForm.ShowDialog();
                e.Cancel = !acceptForm.Accepted;
            }
        }

        private void checkBoxDelivered_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isModified)
                _isModified = true;
        }
    }
}

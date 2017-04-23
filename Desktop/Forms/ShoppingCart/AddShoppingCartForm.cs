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

namespace Desktop.Forms.ShoppingCart
{
    public partial class AddShoppingCartForm : Form
    {
        int _cartId;

        /// <summary>
        /// True - add form, False - edit form
        /// </summary>
        bool _isNew; 

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
           
        }

        private void AddShoppingCartForm_Load(object sender, EventArgs e)
        {
            comboBoxProduct.Items.AddRange(_productService.GetAllNames().ToArray());
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
        }
    }
}

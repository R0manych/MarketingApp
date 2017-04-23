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

        public EditShoppingCartForm()
        {
            InitializeComponent();
        }

        public EditShoppingCartForm(int cartId)
        {
            InitializeComponent();
            _cartId = cartId;
        }

        private void EditShoppingCartForm_Load(object sender, EventArgs e)
        {

        }
    }
}

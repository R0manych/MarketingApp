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
    public partial class ShowAllCartsForm : Form
    {
        private int _clientId;

        public ShowAllCartsForm()
        {
            InitializeComponent();
        }

        public ShowAllCartsForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services.EntityServices;
using BusinessLogic.Services.EntityServices.Interfaces;
using BusinessLogic.Services.BusinessServices;
using BusinessLogic.Services.BusinessServices.Interfaces;

namespace Desktop.Forms.ShoppingCart
{
    public partial class ShowAllCartsForm : Form
    {
        private int _clientId;
        private IClientService _clientService;

        public ShowAllCartsForm()
        {
            InitializeComponent();
        }

        public ShowAllCartsForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
        }

        private void ShowAllCartsForm_Load(object sender, EventArgs e)
        {
            shoppingCartsTableAdapter.Fill(this.shoppingCartDataSet.ShoppingCarts);
            ReloadForm();
            _clientService = new ClientService();
            toolStripComboBoxClient.Items.AddRange(_clientService.GetNames().ToArray());
            toolStripComboBoxClient.SelectedItem = _clientService.SetName(_clientService.GetById(_clientId));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void toolStripComboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clientId = _clientService.GetByName(toolStripComboBoxClient.Text).Id;
            ReloadForm();
        }

        private void ReloadForm()
        {
            shoppingCartsTableAdapter.FillByClientId(shoppingCartDataSet.ShoppingCarts, _clientId);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editForm = new EditShoppingCartForm(_clientId);
            editForm.ShowDialog();
            ReloadForm();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dataGridViewCarts.Rows.Remove(dataGridViewCarts.SelectedRows[0]);
            ReloadForm();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var viewShoppingCartForm = new ViewShoppingCartForm(Convert.ToInt32(dataGridViewCarts.SelectedRows[0].Cells[0].Value));
            viewShoppingCartForm.ShowDialog();
        }

        private void dataGridViewCarts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            shoppingCartsTableAdapter.Update(shoppingCartDataSet);
        }
    }
}

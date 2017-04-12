using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataContextModel.Models;
using BusinessLogic.Services.EntityServices;
using BusinessLogic.Services.EntityServices.Interfaces;
using BusinessLogic.Services.BusinessServices;
using BusinessLogic.Services.BusinessServices.Interfaces;
using Desktop.Forms.ShoppingCart;

namespace Desktop.Forms.Client
{
    public partial class ViewClientForm : Form
    {
    #region fields

        IClientService _clientService;
        ICountService _countService;

        private DataContextModel.Models.Client _currentClient;
        #endregion

    #region constructors

        public ViewClientForm()
        {
            InitializeComponent();
        }

        public ViewClientForm(DataContextModel.Models.Client client)
        {
            InitializeComponent();
            _currentClient = client;
        }

    #endregion


        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewClientForm_Load(object sender, EventArgs e)
        {
            _clientService = new ClientService();
            _countService = new CountService();
            monthForShowPicker.Format = DateTimePickerFormat.Custom;
            monthForShowPicker.CustomFormat = "MM/yyyy";
            Reload();
        }

        private void buttonShowProfit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_countService.CountProfit(_currentClient, monthForShowPicker.Value).ToString());
        }

        private void monthForShowPicker_ValueChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editForm = new EditClientForm(_currentClient);
            editForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            textBoxClient.Text = _clientService.ClientToString(_currentClient, monthForShowPicker.Value);
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            var addCartForm = new AddShoppingCartForm(_currentClient.Id);
            addCartForm.ShowDialog();
        }

        private void buttonShowHistory_Click(object sender, EventArgs e)
        {
            var showCartsForm = new ShowAllCartsForm(_currentClient.Id);
            showCartsForm.ShowDialog();
        }
    }
}

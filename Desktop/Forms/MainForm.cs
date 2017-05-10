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
using Desktop.FormUtils;
using Desktop.Forms.Client;
using Desktop.Forms.ShoppingCart;
using DataContextModel.Repositories;
using Desktop.Forms.Common;

namespace Desktop.Forms
{
    public partial class MainForm : Form
    {
        IClientService _clientService = new ClientService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFormUtils.SetRoot(treeViewClients, _clientService.GetRootClients());            
        }

        private void treeViewClients_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Nodes.Clear();
            var childClients = _clientService.GetChildren(e.Node.Text);
            MainFormUtils.SetNode(e.Node, childClients);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var viewClientForm = new ViewClientForm(_clientService.GetByName(treeViewClients.SelectedNode.Text));
            viewClientForm.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
            MainFormUtils.SetRoot(treeViewClients, _clientService.GetRootClients());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var client = _clientService.GetByName(treeViewClients.SelectedNode.Text);
            var editClientForm = new EditClientForm(client);
            editClientForm.ShowDialog();
            MainFormUtils.SetRoot(treeViewClients, _clientService.GetRootClients());
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var acceptForm = new AcceptForm("Удалить клиента?");
            acceptForm.ShowDialog();
            if (acceptForm.Accepted)
            {
                var parentNode = treeViewClients.SelectedNode.Parent;
                _clientService.Delete(_clientService.GetByName(treeViewClients.SelectedNode.Text));
                if (parentNode != null)
                    MainFormUtils.Reload(parentNode);
                else
                    MainFormUtils.SetRoot(treeViewClients, _clientService.GetRootClients());
            }
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            var addShoppingCartForm = new AddShoppingCartForm(_clientService.GetByName(treeViewClients.SelectedNode.Text).Id);
            addShoppingCartForm.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            var allShoppingCartsForm = new ShowAllCartsForm(_clientService.GetByName(treeViewClients.SelectedNode.Text).Id);
            allShoppingCartsForm.Show();
        }
    }
}

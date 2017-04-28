using BusinessLogic.Services.EntityServices;
using BusinessLogic.Services.EntityServices.Interfaces;
using DataContextModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.FormUtils
{
    public static class MainFormUtils
    {
        public static void SetRoot(TreeView treeViewClients, List<string> clients)
        {
            treeViewClients.Nodes.Clear();
            foreach (var client in clients)
            {
                var node = new TreeNode(client);
                node.Nodes.Add("dummy");
                treeViewClients.Nodes.Add(node);
            }
        }

        public static void SetNode(TreeNode nodeClient, List<Client> clients)
        {
            IClientService _clientService = new ClientService();
            foreach (var client in clients)
            {
                var node = new TreeNode(_clientService.SetName(client));
                node.Nodes.Add("dummy");
                nodeClient.Nodes.Add(node);
            }
        }

        public static void Reload(TreeNode nodeClient)
        {
            IClientService _clientService = new ClientService();
            var childClients = _clientService.GetChildren(nodeClient.Text);
            nodeClient.Nodes.Clear();
            SetNode(nodeClient, childClients);            
        }
    }
}

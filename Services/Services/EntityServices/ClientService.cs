using BusinessLogic.Services.BusinessServices;
using BusinessLogic.Services.BusinessServices.Interfaces;
using BusinessLogic.Services.EntityServices.Interfaces;
using DataContextModel.Models;
using DataContextModel.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.EntityServices
{
    public class ClientService : IClientService
    {
        private const char _separator = '|';
        ICountService _countService = new CountService();

        public Client CreateClient(string Name, string Adress, string BankCard, string Birthday, string Contract, string Email, string Passport, string Phone, string Parent)
        {
            DateTime birth = default(DateTime);
            if (!(string.IsNullOrEmpty(Birthday)))
                birth = Convert.ToDateTime(Birthday);
            int parentId = GetByName(Parent).Id;
            return new Client(Name, Adress, BankCard, birth, Contract, Email, Passport, Phone, parentId);
        }

        public List<Client> GetChildren(string parent)
        {
            var parentClient = GetByName(parent);
            using (var clients = new ClientRepository())
            {
                return clients.GetByParent(parentClient.Id);
            }
        }

        public Client GetByName(string name)
        {
            var contract = name.Split(_separator)[1];
            using (var clients = new ClientRepository())
            {
                return clients.GetAll().Where(c => c.Contract == contract).FirstOrDefault();
            }
        }

        public void Add(Client client)
        {
            using (var clients = new ClientRepository())
            {
                try
                {
                    clients.Add(client);
                }
                catch
                {
                    throw;
                }
            }
        }

        public void Delete(Client client)
        {
            using (var clients = new ClientRepository())
            {
                try
                {
                    int parentId = client.Id;
                    var children = clients.GetByParent(parentId);
                    int newParentId = client.ParentId;
                    if (newParentId != 0)
                    {
                        foreach (var child in children)
                        {
                            child.ParentId = newParentId;
                        }
                    }
                    else
                    {
                        foreach (var child in children)
                        {
                            child.ParentId = newParentId;
                        }
                    }
                    clients.Delete(client.Id);
                    
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Client> GetAll()
        {
            using (var clients = new ClientRepository())
            {
                return clients.GetAll().ToList();
            }
        }

        public List<string> GetNames()
        {
            List<Client> clients = new List<Client>();
            using (var clientsRep = new ClientRepository())
            {
                clients = clientsRep.GetAll().ToList();
            }
            List<string> names = new List<string>();
            foreach (var client in clients)
            {
                names.Add(SetName(client));
            }
            return names;
        }

        public string SetName(Client client) => client.Name + _separator + client.Contract;

        public string ClientToString(Client client, DateTime date)
         => "Имя: " + client.Name + Environment.NewLine +
             "Телефон: " + client.Phone + Environment.NewLine +
             "Адрес: " + client.Adress + Environment.NewLine +
             "Номер карты: " + client.BankCard + Environment.NewLine +
             "Дата рождения: " + client.Birthday.ToShortDateString() + Environment.NewLine +
             "Почта: " + client.Email + Environment.NewLine +
             "Паспорт: " + client.Passport + Environment.NewLine +
             "Контракт: " + client.Contract + Environment.NewLine +
             "Баллы: " + _countService.CountPoints(client, date).ToString() + Environment.NewLine;

        public Client GetById(int id)
        {
            using (var clients = new ClientRepository())
            {
                return clients.GetById(id);
            }
        }

        public void Update(Client client)
        {
            try
            {
                using (var clients = new ClientRepository())
                {
                    clients.Edit(client);
                }
            }
            catch
            {
                throw;
            }
        }  
    }
}

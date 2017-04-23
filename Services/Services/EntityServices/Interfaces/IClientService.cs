using DataContextModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.EntityServices.Interfaces
{
    public interface IClientService : IBaseEntityService<Client>
    {
        List<string> GetNames();

        Client CreateClient
        (
            string Name,
            string Adress,
            string BankCard,
            DateTime Birthday,
            string Contract,
            string Email,
            string Passport,
            string Phone,
            string Parent
        );
        Client GetByName(string name);

        List<Client> GetChildren(string parent);

        string SetName(Client client);

        string ClientToString(Client client, DateTime date);

        List<Client> GetRootClients();
    }
}

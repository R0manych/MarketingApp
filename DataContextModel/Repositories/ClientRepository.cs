
using DataContextModel.Interfaces;
using DataContextModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository()
        {
        }

        public List<Client> GetByParent(int parentId) => Entities.Where(c => c.ParentId == parentId).ToList();
        
    }
}

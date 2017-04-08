using DataContextModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.BusinessServices.Interfaces
{
    public interface ICountService
    {
        double CountProfit(Client client, DateTime date);

        int CountPoints(Client client, DateTime date);
        
    }
}

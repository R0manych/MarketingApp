using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BusinessServices.Interfaces
{
    public interface ICountService
    {
        double CountProfit(int id, DateTime date);

        int CountPoints(int id, DateTime date);
        
    }
}

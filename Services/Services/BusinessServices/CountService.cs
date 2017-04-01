using BusinessLogic.BusinessServices.Interfaces;
using BusinessLogic.Services.EntityServices;
using BusinessLogic.Services.EntityServices.Interfaces;
using DataContextModel.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.BusinessServices
{
    struct PercentSetting
    {
        public int Value;
        public double Percent;
    }

    public class CountService : ICountService
    {
        private const string FILENAME = "settings.txt";
        private const double _leaderPercent = 0.18;

        public double CountProfit(int id, DateTime date)
        {
            var settings = LoadSettings(FILENAME);
            double sum = 0;
            using (var _clientRep = new ClientRepository())
            {
                var client = _clientRep.GetById(id);
                foreach (var child in client.Children)
                {
                    var childSum = CountPoints(child.Id, date);
                    double k = GetValue(settings, childSum);
                    if (k < _leaderPercent)
                    {
                        sum += k * childSum;
                    }
                }
            }
            return sum * ShoppingCartService.PointsValue;
        }

        public int CountPoints(int id, DateTime date)
        {
            IShoppingCartService _cartService = new ShoppingCartService();
            var carts = _cartService.GetAll().Where(c => c.ClientId == id).ToList();
            int sum = 0;
            foreach (var cart in carts)
            {
                if (cart.Date.Year == date.Year && cart.Date.Month == date.Month)
                {
                    sum += _cartService.CountPoints(cart.Id);
                }
            }
            using (var _clients = new ClientRepository())
            {
                var client = _clients.GetById(id);
                foreach (var child in client.Children)
                {
                    sum += CountPoints(child.Id, date);
                }
            }
            return sum;
        }

        private List<PercentSetting> LoadSettings(string fileName)
        {
            var settings = new List<PercentSetting>();
            var sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var lineArr = line.Split(' ');
                settings.Add(new PercentSetting()
                {
                    Value = Convert.ToInt32(lineArr[0]),
                    Percent = Convert.ToDouble(lineArr[1])
                });
            }
            return settings;
        }

        private double GetValue(List<PercentSetting> settings, int searchKey)
        {
            int i = 0;
            while (settings[i].Value <= searchKey && i < settings.Count)
                i++;
            if (i > 0)
                return settings[i - 1].Percent;
            else return 0;
        }
    }
}

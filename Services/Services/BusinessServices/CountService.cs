
using BusinessLogic.Services.BusinessServices.Interfaces;
using BusinessLogic.Services.EntityServices;
using BusinessLogic.Services.EntityServices.Interfaces;
using DataContextModel.Models;
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
        private const double _leaderReward = 0.03;

        public double CountProfit(Client client, DateTime date)
        {
            var settings = LoadSettings(FILENAME);
            double sum = 0;
            var pointsWithoutLeaders = CountAllChildPoint(client, date, settings);
            int countChildLeaders = 0;
            foreach (var child in client.Children)
            {
                var childSum = CountPoints(child, date);
                double koef = GetValue(settings, childSum);
                if (koef < _leaderPercent)
                {
                    sum += koef * childSum;
                }
                else
                {
                    countChildLeaders++;
                    if (pointsWithoutLeaders >= settings.Last().Value && countChildLeaders > 1)
                    {
                        sum += _leaderReward * childSum;
                    }
                    else if (pointsWithoutLeaders >= settings.Last().Value / 2 && countChildLeaders > 1)
                    {
                        sum += _leaderReward / 2 * childSum;
                    }
                }
            }
            return sum * ShoppingCartService.PointsValue;
        }

        private int CountAllChildPoint(Client client, DateTime date, List<PercentSetting> settings)
        {
            int sum = 0;
            foreach (var child in client.Children)
            {
                var childSum = CountPoints(child, date);
                double koef = GetValue(settings, childSum);
                if (koef < _leaderPercent)
                {
                    sum += childSum;
                }
            }
            return sum;
        }

        public int CountPoints(Client client, DateTime date)
        {
            IShoppingCartService _cartService = new ShoppingCartService();
            var carts = _cartService.GetAll().Where(c => c.ClientId == client.Id).ToList();
            int sum = 0;
            foreach (var cart in carts)
            {
                if (cart.Date.Year == date.Year && cart.Date.Month == date.Month)
                {
                    sum += _cartService.CountPoints(cart.Id);
                }
            }
            foreach (var child in client.Children)
            {
                sum += CountPoints(child, date);
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

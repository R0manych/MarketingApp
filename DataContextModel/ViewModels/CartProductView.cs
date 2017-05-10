using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.ViewModels
{
    public class CartProductView
    {        

        [Browsable(false)]
        public int Id { get; }

        [DisplayName("Наименование")]
        public string ProductName { get; }

        [DisplayName("Количество")]
        public int Count { get; set; }

        [Browsable(false)]
        public int CartId { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }

        public CartProductView(string name, int id, int cartId, decimal price)
        {
            Id = id;
            ProductName = name;
            Count = 1;
            CartId = cartId;
            Price = price;
        }
    }
}

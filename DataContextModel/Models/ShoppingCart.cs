using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.Models
{
    public class ShoppingCart : BaseEntity
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public int ClientId { get; set; }

        public bool Delivered {get;set;}

        public virtual Client Client { get; set; }

        public virtual ICollection<CartProduct> Products { get; set; }

        public ShoppingCart()
        {
            Products = new List<CartProduct>();
        }
    }
}

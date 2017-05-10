using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.Models
{
    public class CartProduct : BaseEntity
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CartId { get; set; }

        public int Count { get; set; }

        public virtual Product Product { get; set; }

        public virtual ShoppingCart Cart { get; set; }
    }
}

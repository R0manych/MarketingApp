using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.Models
{
    public class Entities : DbContext
    {
        public Entities() : base("MarketingAppDataConnectionString")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}

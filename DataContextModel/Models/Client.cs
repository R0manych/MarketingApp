using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.Models
{
    public class Client : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Passport { get; set; }

        [Required]
        public string Contract { get; set; }

        public string Adress { get; set; }

        public string BankCard { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set;}

        [Required]
        public int Points { get; set; }

        public int ParentId { get; set; }

        public virtual Client Parent { get; set; }

        public virtual ICollection<Client> Children { get; set; }

        public virtual ICollection<ShoppingCart> Carts { get; set; }

        public Client()
        {
            this.Adress = "";
            this.BankCard = "";
            this.Birthday = DateTime.Now;
            this.Contract = "";
            this.Email = "";
            this.Name = "";
            this.Passport = "";
            this.Phone = "";
            this.Points = 0;
            Children = new List<Client>();
            Carts = new List<ShoppingCart>();
        }

        public Client(string Name, string Adress, string BankCard, DateTime Birthday, string Contract, string Email, string Passport, string Phone, int ParentId)
        {
            this.Name = Name;
            this.Adress = Adress;
            this.Birthday = Birthday;
            this.Contract = Contract;
            this.Email = Email;
            this.Passport = Passport;
            this.Phone = Phone;
            this.Points = 0;
            this.ParentId = ParentId;
            Children = new List<Client>();
            Carts = new List<ShoppingCart>();
        }
    }
}

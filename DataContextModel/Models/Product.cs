﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextModel.Models
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }        
        public string Description { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<CartProduct> CartProducts { get; set; }

        public Product()
        {
            CartProducts = new List<CartProduct>();
        }
    }
}

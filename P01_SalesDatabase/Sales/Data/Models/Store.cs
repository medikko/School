﻿using P03_SalesDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P03_SalesDatabase.Data.Models
{
    public class Store
    {
        public Store()
        {
            this.Sales = new List<Sale>();
        }
        [Key]
        public int StoreId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

         public List<Sale> Sales { get; set; }
    }
}

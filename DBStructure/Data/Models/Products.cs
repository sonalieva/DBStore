using System;
using System.Collections.Generic;
using System.Text;

namespace DBStructure.Data.Models
{
    internal class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

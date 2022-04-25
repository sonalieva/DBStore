using System;
using System.Collections.Generic;
using System.Text;

namespace DBStructure.Data.Models
{
    internal class Comments
    {
        public int Id { get; set; }
        public string Text { get; set; }
        
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Products Products { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

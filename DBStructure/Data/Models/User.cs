using System;
using System.Collections.Generic;
using System.Text;

namespace DBStructure.Data.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

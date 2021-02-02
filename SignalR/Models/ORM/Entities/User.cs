using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Models.ORM.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string ConnectionID { get; set; }
        public bool IsOnline { get; set; }
    }
}

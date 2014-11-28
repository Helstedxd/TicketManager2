using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManager2.Models
{
    class Ticket
    {
        public string TicketID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Purchased { get; set; }
        public bool Used { get; set; }
        public bool Valid { get; set; }

        public Ticket() { }
    }
}

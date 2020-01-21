using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public class Order
    {
        public long Id { get; set; }
        public long CheckNumber { get; set; }    //номер чека (накладной)
        public long CustomerId { get; set; }
        public long ProductId { get; set; }
        public DateTime Date { get; set; }
    }
}

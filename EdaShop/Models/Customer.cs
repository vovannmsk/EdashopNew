using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string NameCustomer { get; set; }
        public string Telephone { get; set; }
        public string Adress { get; set; }
    }
}

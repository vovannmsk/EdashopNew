using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public class SubCategory
    {
        public long Id { get; set; }
        public string NameSub { get; set; }
        public string SubDescription { get; set; }
        public Category Category { get; set; }
    }
}

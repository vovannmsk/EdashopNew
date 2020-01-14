using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        //public string Article { get; set; }
        public string Image { get; set; }
        public string BigImage { get; set; }
        //public Category Category { get; set; }
        //public SubCategory SubCat { get; set; }
        public long CategoryId { get; set; }
        public long SubCatId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public interface iRepository
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Category> Categories  { get; }
        IEnumerable<SubCategory> SubCategories { get; }
        void AddProduct(Product product);
        void AddCategory(Category category);
        void AddSub(SubCategory subCategory);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public class DataRepository:iRepository
    {
        private DataContext context;

        public DataRepository(DataContext ctx) => context = ctx;

        public IEnumerable<Product> Products => context.Products.ToArray();
        public IEnumerable<Category> Categories => context.Categories.ToArray();
        public IEnumerable<SubCategory> SubCategories => context.SubCategories.ToArray();

        public void AddProduct(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }
        public void AddCategory(Category category)
        {
            this.context.Categories.Add(category);
            this.context.SaveChanges();
        }
        public void AddSub(SubCategory subCategory)
        {
            this.context.SubCategories.Add(subCategory);
            this.context.SaveChanges();
        }
    }
}

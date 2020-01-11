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

        public IEnumerable<Product> Products => context.Products;
        public IEnumerable<Category> Categories => context.Categories;
        public IEnumerable<SubCategory> SubCategories => context.SubCategories;

        public void AddProduct(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();
        }
        public void AddProduct(Category category)
        {
            this.context.Categories.Add(category);
            this.context.SaveChanges();
        }
        public void AddProduct(SubCategory subCategory)
        {
            this.context.SubCategories.Add(subCategory);
            this.context.SaveChanges();
        }
    }
}

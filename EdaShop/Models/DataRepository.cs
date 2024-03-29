﻿using System;
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
        public IEnumerable<Customer> Customers => context.Customers.ToArray();
        //public IEnumerable<OrderLine> Order => context.Order.ToArray();

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
        public void AddCustomer(Customer customer)
        {
            this.context.Customers.Add(customer);
            this.context.SaveChanges();
        }
        //public void AddOrderLine(OrderLine orderLine)
        //{
        //    this.context.Order.Add(orderLine);
        //    this.context.SaveChanges();
        //}
    }
}

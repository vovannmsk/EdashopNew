using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public class OrderRepository: iOrderRepository
    {
        private DataContext context;

        public OrderRepository(DataContext ctx) => context = ctx;

        public IEnumerable<Order> Orders => context.Orders.ToArray();
        public IEnumerable<OrderLine> OrderLines => context.OrderLines.ToArray();


        public void AddOrderLine(OrderLine orderLine)
        {
            this.context.OrderLines.Add(orderLine);
            this.context.SaveChanges();
        }

        public Order GetOrder(long checkNumber)
        {
            return (from r in Orders
                   where r.Id == checkNumber
                   select r).FirstOrDefault();

        }

        public IEnumerable<OrderLine> GetOrderLines(long checkNumber)
        {

            return from r in OrderLines
                   where r.CheckNumber == checkNumber
                   orderby r.Id
                   select r;
        }

        public void UpdateOrder(long checkNumber)
        {
            Order order = (from r in Orders
                            where r.Id == checkNumber
                            select r).FirstOrDefault();
            context.Orders.Update(order);
            context.SaveChanges();
        }

        public void UpdateOrderLine(long orderLineId)
        {
            OrderLine lineOfOrder = (from r in OrderLines
                                       where r.Id == orderLineId
                                     select r).FirstOrDefault();
            context.OrderLines.Update(lineOfOrder);
            context.SaveChanges();
        }

        public void DeleteOrderLine(long orderLineId)
        {
            context.OrderLines.Remove(OrderLines.First(r => r.Id == orderLineId));
            context.SaveChanges();
        }

        public void DeleteOrder(long checkNumber)
        {
            context.Orders.Remove(Orders.First(r => r.Id == checkNumber));
            //context.OrderLines.RemoveRange(OrderLines.ToAsyncEnumerable<OrderLine>(r => r.CheckNumber == checkNumber));
            context.OrderLines.RemoveRange(from r in OrderLines
                                           where r.CheckNumber == checkNumber
                                           select r);

            context.SaveChanges();
        }


    }
}

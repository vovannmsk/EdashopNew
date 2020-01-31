using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public interface iOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        IEnumerable<OrderLine> OrderLines { get; }

        /// <summary>
        /// добавить новую строку в заказ
        /// </summary>
        /// <param name="orderLine"></param>
        void AddOrderLine(OrderLine orderLine);

        /// <summary>
        /// получить данные заказа по номеру заказа
        /// </summary>
        /// <param name="checkNumber">номер заказа</param>
        /// <returns></returns>
        Order GetOrder(long checkNumber);


        /// <summary>
        /// получить список товаров заказа (табличная часть заказа) по номеру заказа
        /// </summary>
        /// <param name="checkNumber">номер заказа</param>
        /// <returns></returns>
        IEnumerable<OrderLine> GetOrderLines(long checkNumber);

        /// <summary>
        /// обновить в базе данные заказа
        /// </summary>
        /// <param name="checkNumber">номер заказа</param>
        void UpdateOrder(long checkNumber);

        /// <summary>
        /// сохранить в базе измененную строку заказа
        /// </summary>
        /// <param name="orderLine">номер строки заказа</param>
        void UpdateOrderLine(long orderLine);

        /// <summary>
        /// удалить строку заказа
        /// </summary>
        /// <param name="orderLineId">Id строки заказа</param>
        void DeleteOrderLine(long orderLineId);

        /// <summary>
        /// удалить весь заказ со всеми товарами
        /// </summary>
        /// <param name="orderId">Id заказа</param>
        void DeleteOrder(long orderId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public class Order
    {
        /// <summary>
        /// номер чека (номер заказа) первичный ключ 
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// номер покупателя в справочнике товаров
        /// </summary>
        public long CustomerId { get; set; }
        /// <summary>
        /// Дата и время заказа
        /// </summary>
        public DateTime DateOrder { get; set; }
        /// <summary>
        /// доставлен ли товар
        /// </summary>
        public bool Delivered { get; set; }
        /// <summary>
        /// дата и время доставки
        /// </summary>
        public DateTime DeliveryDate { get; set; }
    }
}

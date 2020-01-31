using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    public class OrderCustomer
    {
        /// <summary>
        /// номер чека (номер заказа) первичный ключ 
        /// </summary>
        public long OrderId { get; set; }
        /// <summary>
        /// номер покупателя в справочнике товаров
        /// </summary>
        public string Customer { get; set; }

        /// <summary>
        /// адрес доставки
        /// </summary>
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// телефон покупателя
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// доставлен ли товар
        /// </summary>
        public bool StatusDelivery { get; set; }

        /// <summary>
        /// Дата и время заказа
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// дата и время доставки
        /// </summary>
        public DateTime DateOfDelivery { get; set; }
    }
}

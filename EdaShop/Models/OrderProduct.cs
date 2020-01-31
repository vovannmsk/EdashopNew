using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdaShop.Models
{
    /// <summary>
    /// строки заказа
    /// </summary>
    public class OrderProduct
    {
        /// <summary>
        /// номер заказа
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// изображение товара (путь к файлу)
        /// </summary>
        public string ProductImage { get; set; }

        /// <summary>
        /// наименование товара
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        /// цена товара
        /// </summary>
        public long GoodsPrice { get; set; }   
    }
}

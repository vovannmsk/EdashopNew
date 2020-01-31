using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EdaShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EdaShop.Controllers
{
    public class OrdersController : Controller
    {
        private iOrderRepository orderRepository;
        private iRepository repository;

        public OrdersController(iOrderRepository orderRepo, iRepository repo)
        {
            orderRepository = orderRepo;
            repository = repo;
        }

        /// <summary>
        /// Вывести все заказы
        /// </summary>
        /// <returns></returns>
        public IActionResult AllOrders()
        {
            //var result = from s in repository.Orders
            //             where s.Delivered      //статус заказа = доставлено
            //             select s;
            ViewBag.Title = "Полный список заказов";
            ViewBag.Orders = from s in orderRepository.Orders
                             join q in repository.Customers
                             on s.CustomerId equals q.Id
                             //where s.Delivered      //статус заказа = доставлено
                             orderby s.Id
                             select new OrderCustomer
                             {
                                 OrderId = s.Id,
                                 Customer = q.NameCustomer,
                                 DeliveryAddress = q.Adress,
                                 Tel = q.Telephone,
                                 StatusDelivery = s.Delivered,
                                 Date = s.DateOrder,
                                 DateOfDelivery = s.DeliveryDate,
                             }; 
            //ViewBag.OrderLines = from r in orderRepository.OrderLines
            //                     join t in repository.Products
            //                     on r.ProductId equals t.Id
            //                     //where s.Delivered      //статус заказа = доставлено
            //                     orderby r.CheckNumber
            //                     select new OrderProduct
            //                     {
            //                         Id = r.CheckNumber,
            //                         ProductImage = t.Image,
            //                         Product = t.Name,
            //                         GoodsPrice = t.Price
            //                     };

            IEnumerable<OrderProduct> result = from r in orderRepository.OrderLines
                                 join t in repository.Products
                                 on r.ProductId equals t.Id
                                 //where s.Delivered      //статус заказа = доставлено
                                 orderby r.CheckNumber
                                 select new OrderProduct
                                 {
                                     Id = r.CheckNumber,
                                     ProductImage = t.Image,
                                     Product = t.Name,
                                     GoodsPrice = t.Price
                                 };

            //var result = from s in orderRepository.Orders
            //             join r in orderRepository.OrderLines
            //             on s.Id equals r.CheckNumber
            //             join t in repository.Products
            //             on r.ProductId equals t.Id
            //             join q in repository.Customers
            //             on s.CustomerId equals q.Id
            //             //where s.Delivered      //статус заказа = доставлено
            //             select new
            //             { OrderId = s.Id,
            //                 Customer = q.NameCustomer,
            //                 DeliveryAddress = q.Adress,
            //                 Tel = q.Telephone,
            //                 StatusDelivery = s.Delivered,
            //                 Date = s.DateOrder,
            //                 DateOfDelivery = s.DeliveryDate,
            //                 Product = t.Name,
            //                 ProductImage = t.Image
            //             };

            return View("ListofOrders", result);
            //return View("ListofOrders", repository.Orders);
        }

        /// <summary>
        /// Вывести все незавершенные заказы
        /// </summary>
        /// <returns></returns>
        public IActionResult NotDeliveredOrders()
        {
            //var result = from s in repository.Orders
            //             where !(s.Delivered)      //статус заказа = не доставлено
            //             select s;

            return View("ListofOrders", orderRepository.Orders.Select(r=>r.Delivered == false));
        }



    }
}

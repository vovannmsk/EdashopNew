using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EdaShop.Models;

namespace EdaShop.Controllers
{
    public class HomeController : Controller
    {
        private iRepository repository;

        public HomeController(iRepository repo) => repository = repo;

        //Главная страница
        public ViewResult Index()
        {

            ViewBag.Title = "Главная";
            ViewBag.Categories = repository.Categories;

            return View("Index");
        }

        //Корзина
        public ViewResult Cart()
        {
            ViewBag.Title = "Корзина";
            ViewBag.Categories = repository.Categories;

            return View("Cart");
        }

        //Акции
        public ViewResult Stocks()
        {

            ViewBag.Title = "Акции";
            ViewBag.Categories = repository.Categories;

            return View("Stocks");
        }

        //Доставка и оплата
        public ViewResult Oplata()
        {

            ViewBag.Title = "Доставка и оплата";
            ViewBag.Categories = repository.Categories;

            return View("Oplata");
        }

        //Отзывы
        public ViewResult Otzovik()
        {

            ViewBag.Title = "Отзывы";
            ViewBag.Categories = repository.Categories;

            return View("Otzovik");
        }

        //Контакты
        public ViewResult Contacts()
        {

            ViewBag.Title = "Контакты";
            ViewBag.Categories = repository.Categories;

            return View("Contacts");
        }

        public ViewResult Pizza()
        {
            //ViewData = repository.SubCategories as IEquatable<SubCategory>;

            //var resultBag = from s in repository.SubCategories
            //                join c in repository.Categories
            //                on s.Category.Id equals c.Id
            //                select new { IdSub = s.Id, NameSub = s.NameSub, DescriptionSub = s.SubDescription, CategoryId = c.Id};
            ViewBag.Title = "Пицца";

            ViewBag.Categories = repository.Categories;

            ViewBag.Sub = from s in repository.SubCategories
                            where s.CategoryId == 1
                            select s;
           
            var result = from r in repository.Products
                         where r.CategoryId == 1
                         orderby r.SubCatId
                         select r;

            return View("Pizza",result);
        }

        public ViewResult Sushi()
        {
            ViewBag.Title = "Суши";

            ViewBag.Categories = repository.Categories;

            ViewBag.Sub = from s in repository.SubCategories
                          where s.CategoryId == 2
                          select s;

            var result = from r in repository.Products
                         where r.CategoryId == 2
                         orderby r.SubCatId
                         select r;

            return View("Sushi", result);
        }

        public ViewResult Rolls()
        {
            ViewBag.Title = "Роллы";

            ViewBag.Categories = repository.Categories;

            ViewBag.Sub = from s in repository.SubCategories
                          where s.CategoryId == 3
                          select s;

            var result = from r in repository.Products
                         where r.CategoryId == 3
                         orderby r.SubCatId
                         select r;

            return View("Rolls", result);
        }

        public ViewResult Fastfood()
        {
            ViewBag.Categories = repository.Categories;

            ViewBag.Sub = from s in repository.SubCategories
                          where s.CategoryId == 4
                          select s;

            var result = from r in repository.Products
                         where r.CategoryId == 4
                         orderby r.SubCatId
                         select r;

            return View("Fastfood", result);
        }

        public ViewResult Wok()
        {
            ViewBag.Categories = repository.Categories;

            ViewBag.Sub = from s in repository.SubCategories
                          where s.CategoryId == 5
                          select s;

            var result = from r in repository.Products
                         where r.CategoryId == 5
                         orderby r.SubCatId
                         select r;

            return View("Wok", result);
        }

        public ViewResult Desserts()
        {
            ViewBag.Categories = repository.Categories;

            ViewBag.Sub = from s in repository.SubCategories
                          where s.CategoryId == 6
                          select s;

            var result = from r in repository.Products
                         where r.CategoryId == 6
                         orderby r.SubCatId
                         select r;
            return View("Desserts", result);
        }

        public ViewResult Ingredients()
        {
            ViewBag.Categories = repository.Categories;

            ViewBag.Sub = from s in repository.SubCategories
                          where s.CategoryId == 7
                          select s;

            var result = from r in repository.Products
                         where r.CategoryId == 7
                         orderby r.SubCatId
                         select r;

            return View("Ingredients", result);
        }
    }
}

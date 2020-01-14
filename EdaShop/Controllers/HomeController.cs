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
            //  < !--горизнтальное меню Список категорий товаров
            //  <ul class="menu">
            //    @//foreach (Category cat in Model)
            //    {
            //        <li class="oneRow">
            //            <a asp-controller="Home" asp-action=@//cat.CategoryDescription>@//cat.NameCategory</a>
            //        </li>
            //    }
            //  </ul>
            //  <!--конец горизнтального меню Список категорий товаров-->

            ViewBag.Title = "Главная";
            return View("Index");
        }

        public ViewResult Pizza()
        {
            //ViewData = repository.SubCategories as IEquatable<SubCategory>;

            //var resultBag = from s in repository.SubCategories
            //                join c in repository.Categories
            //                on s.Category.Id equals c.Id
            //                select new { IdSub = s.Id, NameSub = s.NameSub, DescriptionSub = s.SubDescription, CategoryId = c.Id};
            ViewBag.Title = "Пицца";

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
            return View("Sushi", repository.Categories);
        }

        public ViewResult Rolls()
        {
            return View("Rolls", repository.Categories);
        }

        public ViewResult Fastfood()
        {
            return View("Fastfood", repository.Categories);
        }

        public ViewResult Wok()
        {
            return View("Wok", repository.Categories);
        }

        public ViewResult Desserts()
        {
            return View("Desserts", repository.Categories);
        }

        public ViewResult Ingredients()
        {
            return View("Ingredients", repository.Categories);
        }
    }
}

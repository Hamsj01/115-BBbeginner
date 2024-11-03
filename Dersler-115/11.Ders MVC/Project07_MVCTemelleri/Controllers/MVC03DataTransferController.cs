using Microsoft.AspNetCore.Mvc;
using Project07_MVCTemelleri.Models;

namespace Project07_MVCTemelleri.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        List<Category> categoryList;
        List<Product> productList;
        public MVC03DataTransferController()
        {
            categoryList = [
                    new Category{ Id=1, Name="Telefon", Description="Telefon kategorisi"},
                                new Category{ Id=2, Name="Bilgisayar", Description="Bilgisayar kategorisi"},
                                new Category{ Id=3, Name="Kitap", Description="Kitap kategorisi"},
                                new Category{ Id=4, Name="Oyuncak", Description="Oyuncak kategorisi"}
                    ];
            productList = [
                new Product{Id=1, Name="IPhone 13", CategoryId=1, Price=47000},
                new Product{Id=2, Name="IPhone 14", CategoryId=1, Price=57000},
                new Product{Id=3, Name="IPhone 15", CategoryId=1, Price=67000},
                new Product{Id=4, Name="IPhone 16", CategoryId=1, Price=77000},
                new Product{Id=5, Name="Macbook Air M3", CategoryId=2, Price=47000},
                new Product{Id=6, Name="Lenovo Ideapad X", CategoryId=2, Price=67000},
                new Product{Id=7, Name="Kadınlar Ülkesi", CategoryId=3, Price=300},
                new Product{Id=8, Name="Cesur Yeni Dünya", CategoryId=3, Price=200}
            ];
        }
        public ActionResult Index()
        {
            string name = "Alexandra";
            ViewBag.WelcomeMessage = $"Hoşgeldin {name}";
            ViewBag.CategoryList = categoryList;
            ViewData["CategoryList"] = categoryList;
            return View();
        }
        public ActionResult ModelData()
        {
            //Model bazlı veri yollama
            return View(categoryList);
        }
        public ActionResult HomePage()
        {
            string message = "Uygulamamıza hoş geldiniz!";
            Campaign campaign = new()
            {
                Id = 1,
                Title = "1000 TL üzeri ücretsiz kargo!",
                Description = "Sepet toplamınız 1000 TL ve üzerindeyse kargo bizden!",
                ImageUrl = "/img/campaign-image.jfif"
            };

            HomePageModel model = new()
            {
                Categories = categoryList,
                Products = productList,
                Message = message,
                Campaign = campaign
            };

            return View(model);
        }
    }
}

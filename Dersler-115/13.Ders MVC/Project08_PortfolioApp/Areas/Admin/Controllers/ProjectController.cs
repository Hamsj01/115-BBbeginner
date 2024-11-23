using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project08_PortfolioApp.Areas.Admin.Models;
using Project08_PortfolioApp.Models;

namespace Project08_PortfolioApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        public async Task<ActionResult> Index()
        {
            //Bağlantıyı hazırlıyoruz
            var connectionString = "Server=localhost,1440;Database=PortfolioDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            var connection = new SqlConnection(connectionString);

            //Proje listesini çekiyoruz
            var queryProjects = "select * from Projects";
            var projects = await connection.QueryAsync<Project>(queryProjects);

            return View(projects);
        }

        public async Task<ActionResult> Create()
        {
            AddProjectViewModel model= new(){
                CategoryList=await GetCategoryList()
            };
            return View(model);
        }

        [NonAction]
        private async Task<List<SelectListItem>> GetCategoryList()
        {
            //Bağlantıyı hazırlıyoruz
            var connectionString = "Server=localhost,1440;Database=PortfolioDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
            var connection = new SqlConnection(connectionString);

            //KategoriListesini çekiyoruz
            var queryCategories = "select * from Categories";
            var categories = await connection.QueryAsync<Category>(queryCategories);
            List<SelectListItem> result=[];
            foreach (var category in categories)
            {
                result.Add(new SelectListItem{
                    Text=category.Name,
                    Value=category.Id.ToString()
                });

                
            }
            return result;
        }
    }
}

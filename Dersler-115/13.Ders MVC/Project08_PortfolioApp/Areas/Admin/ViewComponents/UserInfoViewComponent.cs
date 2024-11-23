using System;
using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Project08_PortfolioApp.Models;

namespace Project08_PortfolioApp.Areas.Admin.ViewComponents;

public class UserInfoViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        //Bağlantıyı hazırlıyoruz
        var connectionString = "Server=localhost,1440;Database=PortfolioDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
        var connection = new SqlConnection(connectionString);

        //Site ayarlarını çekiyoruz
        var queryAppSetting = "select BrandName from AppSettings";
        var appSetting = (await connection.QueryAsync<AppSetting>(queryAppSetting)).First();
        return View(appSetting);
        // return View("Default",appSetting.BrandName);
    }
    // public IViewComponentResult Invoke()
    // {

    // }
}

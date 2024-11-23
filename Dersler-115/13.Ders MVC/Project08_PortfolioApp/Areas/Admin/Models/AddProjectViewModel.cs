using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project08_PortfolioApp.Areas.Admin.Models;
public class AddProjectViewModel
{
    [Required(ErrorMessage = "Proje adı boş bırakılamaz")]
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? GithubUrl { get; set; }
    public string? ImageUrl { get; set; }
    public bool IsActive { get; set; }
    public int CategoryId { get; set; }
    public List<SelectListItem>? CategoryList { get; set; }
    public IFormFile Image { get; set; }
}



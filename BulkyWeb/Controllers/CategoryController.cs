using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BulkyWeb.Models;

namespace BulkyWeb.Controllers;

public class CategoryController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}

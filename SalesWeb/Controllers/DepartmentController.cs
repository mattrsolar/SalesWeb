using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWeb.Models;

namespace SalesWeb.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Books" });

            return View(list);
        }
    }
}

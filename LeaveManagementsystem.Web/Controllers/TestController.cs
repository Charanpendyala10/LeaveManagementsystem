using LeaveManagementsystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementsystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "student",
                //DateOfBirth = new DateTime(2002,05,10)
            };
            return View(data);
        }
    }
}

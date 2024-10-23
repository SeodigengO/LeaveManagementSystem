using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of Onthatile",
                DateOfBirth = new DateTime(2001,11,06)

            };

            return View(data);
        }
    }
}

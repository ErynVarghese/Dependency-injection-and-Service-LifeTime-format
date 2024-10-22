using Microsoft.AspNetCore.Mvc;

namespace To_Do_List_App.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

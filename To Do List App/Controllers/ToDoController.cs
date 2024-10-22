using Microsoft.AspNetCore.Mvc;
using To_Do_List_App.Models;
using To_Do_List_App.Services;
using To_Do_List_App.Interfaces;

namespace To_Do_List_App.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ITodoService _TodoServices;

        private readonly IAppSettings _AppSettings;

        private readonly ITaskLogger _TaskLogger;

     
        public  ToDoController(ITodoService TodoService,IAppSettings AppSettings,ITaskLogger TaskLogger)
        {
            _TodoServices = TodoService;
            _AppSettings = AppSettings;
            _TaskLogger = TaskLogger;
        }
        public IActionResult Index()
        {
            ViewBag.AppName = _AppSettings.AppName;
            var tasks = _TodoServices.GetTasks();
            return View(tasks);
        }

        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(string task)
        {
               
             var newTask = new ToDoItem
             {
                  Task = task,
                  IsComplete = false 
             };

             _TodoServices.AddTask(newTask);
             _TaskLogger.WriteMessage($"Added Task: {task}");

            
             return RedirectToAction("Index");
        }

        public IActionResult MarkComplete (int id)
        {
            _TodoServices.MarkComplete(id);

            var task = _TodoServices.GetTasks().FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _TaskLogger.WriteMessage($" Task Completed: {task.Task}");
            }
           
            return RedirectToAction("Index");
        }
    }
}

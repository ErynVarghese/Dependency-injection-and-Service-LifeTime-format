using To_Do_List_App.Interfaces;
using To_Do_List_App.Models;
using System.Collections.Generic;
using System.Linq;
using To_Do_List_App.Data;

namespace To_Do_List_App.Services
{
    public class TodoService : ITodoService
    {
        
        private readonly ApplicationDbContext _context;

        public TodoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ToDoItem> GetTasks()
        {
           
            return _context.ToDoItems.ToList();

        }


        public void AddTask(ToDoItem task)
        {
            _context.ToDoItems.Add(task);
            _context.SaveChanges();

        }

        public void MarkComplete(int id)
        {
            var task = _context.ToDoItems.FirstOrDefault(x => x.Id == id);

            if (task != null)
            {
                task.IsComplete = true;
                _context.SaveChanges();
            }
        }
    }
}

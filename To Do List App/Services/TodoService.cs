using To_Do_List_App.Models;

namespace To_Do_List_App.Services
{
    public class TodoService : ITodoService
    {
        private List<ToDoItem> _tasks =  new List<ToDoItem>();

        public List<ToDoItem> GetTasks()
        {
            return _tasks;
        }

        public void AddTask(ToDoItem task)
        {
            task.Id = _tasks.Count + 1;
            _tasks.Add(task);
        }

        public void MarkComplete(int id)
        {
            var task = _tasks.FirstOrDefault(x => x.Id == id);

            if (task != null)
            {
                task.IsComplete = true;
            }
        }
    }
}

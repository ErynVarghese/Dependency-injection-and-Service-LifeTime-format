using To_Do_List_App.Models;

namespace To_Do_List_App.Services
{
    public interface ITodoService
    {
        List<ToDoItem> GetTasks();

        void AddTask(ToDoItem task);

        void MarkComplete(int id);
    }

}

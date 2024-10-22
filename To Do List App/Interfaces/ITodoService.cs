using To_Do_List_App.Models;

namespace To_Do_List_App.Interfaces
{
    public interface ITodoService
    {
        List<ToDoItem> GetTasks();

        void AddTask(ToDoItem task);

        void MarkComplete(int id);
    }

}

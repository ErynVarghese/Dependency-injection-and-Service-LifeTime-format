using System.Diagnostics;
using To_Do_List_App.Interfaces;

namespace To_Do_List_App.Services
{
    public class TaskLogger : ITaskLogger
    {
        public void WriteMessage (string message)
        {
            Debug.WriteLine($"Task Logged: {message}");
        }
    }
}

namespace To_Do_List_App.Services
{
    public class TaskLogger : ITaskLogger
    {
        public void Log (string message)
        {
            Console.WriteLine($"Task Logged: {message}");
        }
    }
}

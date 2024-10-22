using Microsoft.EntityFrameworkCore;
using To_Do_List_App.Models;

namespace To_Do_List_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data
{
    public class TodoDBContext :DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options) { }

        public DbSet<TodoItem> todoItems { get; set; }
    }
}

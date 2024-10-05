using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoList.Models;

namespace TodoList.API.Data
{
    public class TodoListDbContext : DbContext
    {
        public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
        {
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Person> Person{get;set;}
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

    }
}
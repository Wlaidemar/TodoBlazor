using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options):base(options)
        {}

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}

using System.Collections.Generic;
using TodoList.Models;

namespace TodoList.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<TodoItem> GetAllItems();
        void AddTodo(string todoName);
        void ValueChanged(TodoItem changedItem);
        void DeleteItem(int id);
    }
}

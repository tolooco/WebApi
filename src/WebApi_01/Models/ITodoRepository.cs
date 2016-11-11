using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_01.Models
{
   public interface ITodoRepository
    {
        void Add(TodoItem item);
        void Update(TodoItem item);

        TodoItem Find(string key);
        TodoItem Remove(string key);

        IEnumerable<TodoItem> GetAll();
    }
}

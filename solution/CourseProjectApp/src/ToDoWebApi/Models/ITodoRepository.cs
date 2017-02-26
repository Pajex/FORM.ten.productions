using System.Collections;
using System.Collections.Generic;

namespace ToDoWebApi.Models
{
    public interface ITodoRepository
    {
        void Add(ToDoItem item);
        IEnumerable<ToDoItem> GetAll();
        ToDoItem Find(long key);
        void Remove(long key);
        void Update(ToDoItem item);
    }
}
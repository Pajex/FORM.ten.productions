using System.Collections.Generic;

namespace ToDoWebApi.Models
{
    public class ToDoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
            Add(new ToDoItem { Name = "Item1" });
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        public void Add(ToDoItem item)
        {
            _context.TodoItems.Add(item);
            _context.SaveChanges();
        }

        public ToDoItem Find(long key)
        {
            return _context.TodoItems.FirstOrDefault(t => t.Key == key);
        }

        public void Remove(long key)
        {
            var entity = _context.TodoItems.First(t => t.Key == key);
            _context.TodoItems.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(ToDoItem item)
        {
            _context.TodoItems.Update(item);
            _context.SaveChanges();
        }
    }
}
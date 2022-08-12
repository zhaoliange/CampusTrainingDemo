using DependencyInjectionMvcDemo.Models;

namespace DependencyInjectionMvcDemo.Interfaces
{
    public interface IToDoItemRepository
    {
        IEnumerable<ToDoItem> List();
    }
}

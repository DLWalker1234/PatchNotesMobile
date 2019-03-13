using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatchNotes
{
    public interface ISteamService
    {
        Task<List<TodoItem>> RefreshDataAsync();

        Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

        Task DeleteTodoItemAsync(string id);
    }
}
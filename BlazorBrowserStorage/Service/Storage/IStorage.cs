using System.Threading.Tasks;

namespace BlazorBrowserStorage
{
    public interface IStorage
    {
        ValueTask<T> GetItem<T>(string key);
        ValueTask<string> Key(int index);
        ValueTask RemoveItem(string key);
        ValueTask SetItem<T>(string key, T item);
        ValueTask Clear();
        ValueTask<int> Length();
    }
}

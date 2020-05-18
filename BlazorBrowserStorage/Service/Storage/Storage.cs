using Microsoft.JSInterop;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorBrowserStorage
{
    internal abstract class Storage : IStorage
    {
        private readonly IJSRuntime JSRuntime;
        private readonly string StorageName;
        protected Storage(IJSRuntime jSRuntime, string storageName)
        {
            JSRuntime = jSRuntime;
            StorageName = storageName;
        }
        public ValueTask<int> Length() => JSRuntime.InvokeAsync<int>("eval", $"window.{StorageName}.length");
        public ValueTask Clear() => JSRuntime.InvokeVoidAsync($"window.{StorageName}.clear");
        public async ValueTask<T> GetItem<T>(string key)
        {
            return JsonConvert.DeserializeObject<T>(await JSRuntime.InvokeAsync<string>($@"window.{StorageName}.getItem", key));
        }
        public ValueTask<string> Key(int index) => JSRuntime.InvokeAsync<string>($@"window.{StorageName}.key", index);
        public ValueTask RemoveItem(string key)
        {
            return JSRuntime.InvokeVoidAsync($@"window.{StorageName}.removeItem", key);
        }
        public ValueTask SetItem<T>(string key, T item)
        {
            return JSRuntime.InvokeVoidAsync($@"window.{StorageName}.setItem", key, JsonConvert.SerializeObject(item));
        }
    }
}

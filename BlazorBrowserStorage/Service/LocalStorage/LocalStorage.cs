using Microsoft.JSInterop;

namespace BlazorBrowserStorage
{
    internal class LocalStorage : Storage, ILocalStorage
    {
        public LocalStorage(IJSRuntime jSRuntime) : base(jSRuntime, StorageTypes.LocalStorage) { }
    }
}

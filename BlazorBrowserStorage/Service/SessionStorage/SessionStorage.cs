using Microsoft.JSInterop;

namespace BlazorBrowserStorage
{
    internal class SessionStorage : Storage, ISessionStorage
    {
        public SessionStorage(IJSRuntime jSRuntime) : base(jSRuntime, StorageTypes.SessionStorage) { }
    }
}

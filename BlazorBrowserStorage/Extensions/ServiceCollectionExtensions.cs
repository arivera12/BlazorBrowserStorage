using Microsoft.Extensions.DependencyInjection;

namespace BlazorBrowserStorage
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers blazor storage service
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBlazorBrowserStorage(this IServiceCollection services)
        {
            return services.AddScoped<ISessionStorage, SessionStorage>()
                .AddScoped<ILocalStorage, LocalStorage>();
        }
    }
}

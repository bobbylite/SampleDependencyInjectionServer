using DependencyInjectionApp.Services;
using DependencyInjectionApp.Common;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionApp.DependencyInjection
{
    public class ServicesModule : BaseModule 
    {
        protected override void RegisterServiceModule(IServiceCollection serviceModule)
        {
            serviceModule.AddSingleton<IAutoStart, WebEndpointService>();
            serviceModule.AddSingleton<IAutoStart, SortingService>();
            serviceModule.AddSingleton<IAutoStart, PalindromeFinderService>();
        }
    }
}
using System;
using Dependency.Injection.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency.Injection.Core.ExtensionsMethod
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<IAlbumService, AlbumService>();
            return services;
        }
    }
}

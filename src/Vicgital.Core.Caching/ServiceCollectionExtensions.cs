﻿using Microsoft.Extensions.DependencyInjection;
using Vicgital.Core.Caching.Services.InMemoryCache;

namespace Vicgital.Core.Caching
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Injects IInMemoryCache
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInMemoryCache(this IServiceCollection services) =>
            services.AddMemoryCache().AddSingleton<IInMemoryCacheService, InMemoryCacheService>();
    }
}

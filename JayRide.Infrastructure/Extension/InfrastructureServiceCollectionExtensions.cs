using System;
using System.Collections.Generic;
using JayRide.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace JayRide.Infrastructure.Extension
{
    public static class InfrastructureServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastureServices(this IServiceCollection services)
        {
            services.AddHttpClient<ICityLocaterClient,IPStackCityLocater>();
            services.AddHttpClient<IQuotesClient,QuoteAPIClient>();
            return services;
        }
    }
}

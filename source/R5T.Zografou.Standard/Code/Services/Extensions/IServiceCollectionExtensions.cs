using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Zografou.Default;


namespace R5T.Zografou.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ITestingDataDirectoryNameConvention"/> service.
        /// </summary>
        public static IServiceCollection AddTestingDataDiretoryNameConvention(this IServiceCollection services)
        {
            services.AddDefaultTestingDataDirectoryNameConvention();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ITestingDataDirectoryNameConvention"/> service.
        /// </summary>
        public static ServiceAction<ITestingDataDirectoryNameConvention> AddTestingDataDiretoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ITestingDataDirectoryNameConvention>(() => services.AddDefaultTestingDataDirectoryNameConvention());
            return serviceAction;
        }
    }
}

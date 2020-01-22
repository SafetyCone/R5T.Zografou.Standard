using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Zografou.Default;


namespace R5T.Zografou.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddTestingDataDiretoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<ITestingDataDirectoryNameConvention, TestingDataDirectoryNameConvention>();

            return services;
        }
    }
}

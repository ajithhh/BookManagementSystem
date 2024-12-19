namespace BMS.Infra.DAL
{
    using BMS.Core.Interfaces;
    using BMS.Infra.DAL.Repositories;
    using Microsoft.Extensions.DependencyInjection;

    public static class ResolveInfraDependency
    {
        public static void AddInfraServices(this IServiceCollection services)
        {
            services.AddSingleton<IBookRepository, BookRepository>();
        }
    }
}
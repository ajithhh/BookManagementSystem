namespace BMS.Application
{
    using BMS.Application.Interfaces;
    using BMS.Application.Services;
    using BMS.Infra.DAL;
    using Microsoft.Extensions.DependencyInjection;

    public static class ResolveApplicationDependency
    {

        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IBookService, BookService>();
            services.AddInfraServices();
        }
    }
}
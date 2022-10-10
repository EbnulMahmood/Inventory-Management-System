using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using InventoryManagementSystem.Application.IDaos;
using InventoryManagementSystem.Application.IServices;
using InventoryManagementSystem.Infrastructure.Daos;
using InventoryManagementSystem.Infrastructure.Mappings;
using InventoryManagementSystem.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryManagementSystem.Infrastructure.Extensions
{
    public static class FluentNHibernate
    {
        public static IServiceCollection AddFluentNHibernate(this IServiceCollection services,
            string connectionString)
        {
            var sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(connectionString))
                .Mappings(m =>
                {
                    m.FluentMappings.AddFromAssemblyOf<CategoryMap>();
                })
                .BuildSessionFactory();

            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());
            services.AddScoped<ICategoryDao, CategoryDao>();
            services.AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;

namespace TaskMate.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services)
        {
            // Repositórios
            //services.AddScoped<ITaskRepository, TaskRepository>();

            return services;
        }
    }
}

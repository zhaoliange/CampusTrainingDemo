namespace DependencyInjectionDemo
{
    public static class MyDependencyGroupServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            services.AddCors();

            return services;
        }
    }
}

namespace Inveon.GatewaySolution.Extensions
{
    public static class CorsPolicy
    {
        public static IServiceCollection configureCors(this IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
            {
                builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
            }
            ));
            return services;
        }
    }
}

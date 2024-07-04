namespace CaseStudy.Api.CustomCqrsMediator
{
    public static class ServiceMeidatRRegistration
    {
        public static void AddMediatRServices(this IServiceCollection services)
        {
            services.AddMediatR(m =>
            {
                m.RegisterServicesFromAssembly(typeof(ServiceMeidatRRegistration).Assembly);
            });
        }
    }
}
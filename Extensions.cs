namespace BibleContentLibrary;
public static partial class Extensions
{
    extension (IServiceCollection services)
    {
        public IServiceCollection RegisterICBServices()
        {
            return services.RegisterBookDataServices<ChildrenTranslationService>();
        }
        public IServiceCollection RegisterNLTServices()
        {
            return services.RegisterBookDataServices<NewLivingTranslationService>();
        }
        public IServiceCollection RegisterFlexibleTranslationServices<T>()
            where T : class, IFlexibleDefaultTranslationService
        {
            services.AddScoped<IFlexibleDefaultTranslationService, T>()
                .RegisterBookDataServices<FlexibleTranslationService>();
            return services;
        }
    }
    
}
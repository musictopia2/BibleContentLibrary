namespace BibleContentLibrary;
public static partial class Extensions
{
    public static IServiceCollection RegisterICBServices(this IServiceCollection services)
    {
        return services.RegisterBookDataServices<ChildrenTranslationService>();
    }
    public static IServiceCollection RegisterNLTServices(this IServiceCollection services)
    {
        return services.RegisterBookDataServices<NewLivingTranslationService>();
    }
    public static IServiceCollection RegisterFlexibleTranslationServices<T>(this IServiceCollection services)
        where T: class, IFlexibleDefaultTranslationService
    {
        services.AddScoped<IFlexibleDefaultTranslationService, T>()
            .RegisterBookDataServices<FlexibleTranslationService>();
        return services;
    }
}
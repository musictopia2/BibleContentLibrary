using Microsoft.Extensions.DependencyInjection;
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
}
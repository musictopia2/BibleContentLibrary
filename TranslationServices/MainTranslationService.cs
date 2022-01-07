using BibleDatabaseLibrary.Entities;
namespace BibleContentLibrary.TranslationServices;
public abstract class MainTranslationService : ITranslationService
{
    public abstract string DefaultTranslationAbb { get; }

    internal static BasicList<TranslationInformation> Translations = new();
    public async Task<BasicList<TranslationInformation>> ListTranslationsAsync()
    {
        await PopulateTranslationsAsync();
        return Translations.ToBasicList(); //copy to list.  this way whatever a person does will not affect anything else.
    }
    internal static async Task PopulateTranslationsAsync()
    {
        if (Translations.Count == 0)
        {
            return;
        }
        Translations = await rr.GetResourceAsync<BasicList<TranslationInformation>>();
    }
    internal static bool TranslationSupported(string abb) //iffy.
    {
        foreach (var item in Translations)
        {
            if (item.TranslationAbb.ToLower() == abb)
            {
                return true;
            }
        }
        return false;
    }
}
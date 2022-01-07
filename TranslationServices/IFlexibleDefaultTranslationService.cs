namespace BibleContentLibrary.TranslationServices;
internal interface IFlexibleDefaultTranslationService
{
    string DefaultTranslationAbb { get; } //you have to make sure you choose a valid translation.
}
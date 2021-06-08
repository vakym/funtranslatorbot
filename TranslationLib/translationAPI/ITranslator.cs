
namespace TranslationLib
{
    public interface ITranslator
    {
        string GetTranslation(string inputText, string sourceLanguage, string targetLanguage);
        string GetTextLanguage(string inputText);
    }
}

using System;
using funtranslatorbot.translationAPI;



namespace funtranslatorbot.translationAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var translator = new Translator();
            string result = translator.GetTranslation("Hello world", "en", "ru");
            string lang = translator.GetTextLanguage("Hello world");
        }
    }
}

using System;
using funtranslatorbot.translationAPI;

namespace funtranslatorbot
{
    class Program
    {
        static void Main(string[] args)
        {
            var translator = new Translator();
            string result = translator.GetTranslation("Hello world", "en", "ru");
            
        }
    }
}

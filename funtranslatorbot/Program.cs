using System;
using funtranslatorbot.translationAPI;



namespace funtranslatorbot.translationAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var translator = new Translator();
            var langs = translator.GetAvailableLanguages();
            var someShit = new TranslateRURU();
            var result = someShit.TranslateCount("", 10);
            Console.WriteLine(result);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLib
{
    public class TranslateRURU : ITranslateRURU
    {
        private readonly Translator translator = new Translator();
        private readonly List<string> availableLanguages;
        private readonly Random rand = new Random();
        public TranslateRURU()
        {
            availableLanguages = translator.GetAvailableLanguages();
        }
        public string TranslateCount(string inputData, int count)
        {
            string sourceLanguage = translator.GetTextLanguage(inputData);
            for (int i = 0; i < count-1; i++)
            {
                string targetLanguage = GetRandomLanguage();
                inputData = translator.GetTranslation(inputData, sourceLanguage, targetLanguage);
                sourceLanguage = targetLanguage;
            }
            return translator.GetTranslation(inputData, sourceLanguage, "ru");
        }

        private string GetRandomLanguage()
        {
            int index = rand.Next(0, availableLanguages.Count);
            return availableLanguages[index];
        }
    }
}

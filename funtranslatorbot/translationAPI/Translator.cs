using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace funtranslatorbot.translationAPI
{
    public class Translator : ITranslator
    {
        private readonly string baseHostURL = "https://translate.yandex.net/api/v1.5/tr.json";
        private readonly string APIKey = "";
        private readonly string textFormat = "plain";
        private readonly HttpClient httpClient = new HttpClient();
        public string GetTextLanguage(string inputText)
        {
            throw new NotImplementedException();
        }

        public string GetTranslation(string inputText, string sourceLanguage, string targetLanguage)
        {
            throw new NotImplementedException();
        }
    }
}

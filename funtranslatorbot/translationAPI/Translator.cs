using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace funtranslatorbot.translationAPI
{
    public class Translator : ITranslator
    {
        private readonly string baseHostURL = "https://api.cognitive.microsofttranslator.com";
        private readonly string APIKey = "0955c66aaea5418595388eb967bc2b2a";
        private readonly string textFormat = "plain";
        private readonly HttpClient httpClient = new HttpClient();
        public string GetTextLanguage(string inputText)
        {
            throw new NotImplementedException();
        }

        public string GetTranslation(string inputText, string sourceLanguage, string targetLanguage)
        {
            var url = baseHostURL.AppendPathSegment("/translate")
                                 .SetQueryParam("api-version", "3.0")
                                 .SetQueryParams(new
                                 {
                                     from = sourceLanguage,
                                     to = targetLanguage

                                 }).ToString();
            var result = url.WithHeader("Ocp-Apim-Subscription-Key", APIKey)
                            .WithHeader("Ocp-Apim-Subscription-Region", "westeurope")
                            .PostJsonAsync(new[] { new { text = inputText } })
                            .Result;
            var stringResponse = result.ResponseMessage.Content.ReadAsStringAsync().Result;
            return GetTextMessageFromJson(stringResponse);
                        
        }
        private string GetTextMessageFromJson (string inputJson)
        {
            int trimBeginCount = 27;
            int trimEndCount = 15;
            return inputJson.Substring(trimBeginCount, inputJson.Length - trimBeginCount - trimEndCount);
        }
    }
    
}

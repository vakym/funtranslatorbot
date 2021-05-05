﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using funtranslatorbot.DTO;
using Newtonsoft.Json;

namespace funtranslatorbot.translationAPI
{
    public class Translator : ITranslator
    {
        private readonly string baseHostURL = "https://api.cognitive.microsofttranslator.com";
        private readonly string APIKey = "0955c66aaea5418595388eb967bc2b2a";
        
        public string GetTextLanguage(string inputText)
        {
            var url = baseHostURL.AppendPathSegment("/detect")
                                .SetQueryParam("api-version", "3.0")
                                .ToString();
            var result = url.WithHeader("Ocp-Apim-Subscription-Key", APIKey)
                            .WithHeader("Ocp-Apim-Subscription-Region", "westeurope")
                            .PostJsonAsync(new[] { new { text = inputText } })
                            .Result;
            var stringResponse = result.ResponseMessage.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<List<DetectedLanguageDTO>>(stringResponse).First().language;
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
            return JsonConvert.DeserializeObject<List<TranslatedTextDTO>>(inputJson).First().translations[0].text;
        }
    }
    
}

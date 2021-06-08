using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funtranslatorbot.translationAPI
{
    public interface ITranslator
    {
        string GetTranslation(string inputText, string sourceLanguage, string targetLanguage);
        string GetTextLanguage(string inputText);
    }
}

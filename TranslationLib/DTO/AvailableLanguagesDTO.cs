using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLib.DTO
{
    public class AvailableLanguagesDTO
    {
        public Dictionary<string, LanguagePropertiesDTO> translation { get; set; }
    }
}

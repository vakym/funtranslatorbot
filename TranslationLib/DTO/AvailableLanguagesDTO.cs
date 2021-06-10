using System.Collections.Generic;

namespace TranslationLib.DTO
{
    public class AvailableLanguagesDTO
    {
        public Dictionary<string, LanguagePropertiesDTO> Translation { get; set; }
    }
}

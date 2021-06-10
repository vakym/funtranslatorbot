using System.Collections.Generic;

namespace TranslationLib.DTO
{
    public class TranslatedTextDTO
    {
        public List<Translation> Translations { get; set; }
    }
    public class Translation
    {
        public string Text { get; set; }
        public string To { get; set; }
    }
}

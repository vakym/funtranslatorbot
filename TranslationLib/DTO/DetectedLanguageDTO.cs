using System.Collections.Generic;

namespace TranslationLib.DTO
{
    public class DetectedLanguageDTO
    {
        public List<Alternative> Alternatives { get; set; }
        public bool IsTranslationSupported { get; set; }
        public bool IsTransliterationSupported { get; set; }
        public string Language { get; set; }
        public double Score { get; set; }
    }

    public class Alternative
    {
        public bool IsTranslationSupported { get; set; }
        public bool IsTransliterationSupported { get; set; }
        public string Language { get; set; }
        public double Score { get; set; }
    }
}

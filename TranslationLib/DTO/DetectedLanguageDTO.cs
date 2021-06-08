using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationLib.DTO
{
    public class DetectedLanguageDTO
    {
        public List<Alternative> alternatives { get; set; }
        public bool isTranslationSupported { get; set; }
        public bool isTransliterationSupported { get; set; }
        public string language { get; set; }
        public double score { get; set; }
    }

    public class Alternative
    {
        public bool isTranslationSupported { get; set; }
        public bool isTransliterationSupported { get; set; }
        public string language { get; set; }
        public double score { get; set; }
    }
}

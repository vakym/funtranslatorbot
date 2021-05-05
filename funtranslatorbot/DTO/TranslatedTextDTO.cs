using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funtranslatorbot.DTO
{
    public class TranslatedTextDTO
    {
        public List<Translation> translations { get; set; }
    }
    public class Translation
    {
        public string text { get; set; }
        public string to { get; set; }
    }
}

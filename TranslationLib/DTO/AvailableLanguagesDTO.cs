using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funtranslatorbot.DTO
{
    public class AvailableLanguagesDTO
    {
        public Dictionary<string, LanguagePropertiesDTO> translation { get; set; }
    }
}

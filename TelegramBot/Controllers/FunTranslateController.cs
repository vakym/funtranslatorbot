using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TranslationLib;

namespace FunTranslateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunTranslateController : ControllerBase
    {
        [HttpGet]
        public string Get([FromQuery] string text, [FromQuery] int count)
        {
            if (string.IsNullOrEmpty(text) || count <= 0)
            {
                return BadRequest().ToString();
            }
            
            var translateRURU = new TranslateRURU();
            return translateRURU.TranslateCount(text, count);              
            
        }
    }
}

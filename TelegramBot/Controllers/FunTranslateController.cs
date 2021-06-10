using Microsoft.AspNetCore.Mvc;
using TranslationLib;

namespace FunTranslateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunTranslateController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] string text, [FromQuery] int count)
        {
            if (string.IsNullOrEmpty(text) || count <= 0) return BadRequest();
            var translateRURU = new TranslateRURU();
            return Ok(translateRURU.TranslateCount(text, count));              
        }
    }
}

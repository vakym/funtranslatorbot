using Microsoft.AspNetCore.Mvc;
using TranslationLib;

namespace FunTranslateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunTranslateController : ControllerBase
    {
        private readonly ITranslateRURU translateRURU;

        public FunTranslateController(ITranslateRURU translateRURU)
        {
            this.translateRURU = translateRURU;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string text, [FromQuery] int count)
        {
            if (string.IsNullOrEmpty(text) || count <= 0) return BadRequest();
            return Ok(translateRURU.TranslateCount(text, count));              
        }
    }
}

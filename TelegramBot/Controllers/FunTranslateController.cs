using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TranslationLib;

namespace FunTranslateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FunTranslateController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var translateRURU = new TranslateRURU();
            return translateRURU.TranslateCount("сорок обезьян чо то там банан", 5);
        }
    }
}

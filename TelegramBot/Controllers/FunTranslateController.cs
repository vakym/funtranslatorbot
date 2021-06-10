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
        public string Get(string query)
        {
            var uri = new Uri(query);
            //здесь еще офигенная защита от дурака
            var fragment = uri.Fragment.TrimStart('?'); 
            var text = HttpUtility.ParseQueryString(fragment).Get("text");
            var count = int.Parse(HttpUtility.ParseQueryString(fragment).Get("count"));
            var translateRURU = new TranslateRURU();
            return translateRURU.TranslateCount(text, count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;

namespace Localization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : Controller
    {
        private readonly IStringLocalizer _localizer;
        readonly JsonStringLocalizer stringLocalizer;

        public InfoController(IStringLocalizer<InfoController> localizer, JsonStringLocalizer stringLocalizer )
        {
            _localizer = localizer;
            this.stringLocalizer = stringLocalizer;



        }

        public string TestLoc()
        {
            string msg =  
                         " Info resx " + stringLocalizer["Home"];
            return msg;
        }
    }
}
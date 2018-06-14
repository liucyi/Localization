using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Localization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TestController : Controller
    {
        private readonly IStringLocalizer _localizer;
       

        
        public TestController(IStringLocalizer<TestController> localizer)
        {
            _localizer = localizer;
        }

        public string About()
        {
            return _localizer["Hello"];
              
        }
    }
}
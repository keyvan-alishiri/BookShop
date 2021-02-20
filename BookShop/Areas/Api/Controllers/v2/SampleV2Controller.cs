using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Api.Controllers.v2
{
    [Route("api/[controller]")]
    // [Route("api/{v:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class SampleV2Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<String> Get()
        {
            return new string[] { "value1 from version2", "value2 from version2" };
        }


    }
}
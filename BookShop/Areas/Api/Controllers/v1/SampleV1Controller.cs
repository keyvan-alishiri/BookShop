using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Api.Controllers.v1
{

    // [Route("api/[controller]")]
    // [Route("api/{v:apiVersion}/[controller]")]
    //[Route("api/v{v:apiVersion}/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1" , Deprecated =true)]
    [ApiVersion("3")]
    public class SampleV1Controller : ControllerBase
    {
    

        [HttpGet]
        public virtual IEnumerable<String> Get()
        {
            var apiVersion = HttpContext.GetRequestedApiVersion().ToString();
            return new string[] { $"value1 from version{apiVersion}", $"value2 from version{apiVersion}", apiVersion };
        }



        [HttpGet("{name}"),MapToApiVersion("3.0")]
        public string Get(string name)
        {
            return name;
        }



        /// <summary>
        /// Test Error Handle Json OutPut and  Middleware(Development & Production)
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet("[action]")]
        public int test()
        {
            int  i = 0;
            int num = 78 / i;

            return num;
        }
    }
}
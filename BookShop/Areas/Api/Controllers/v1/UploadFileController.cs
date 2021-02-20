using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Areas.Api.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class UploadFileController : ControllerBase
    {
        private readonly IHostingEnvironment _environment;
        public UploadFileController(IHostingEnvironment environment)
        {
            _environment = environment;
        }
        [HttpPost]
        public async Task<string> UploadImage([FromBody]string ImageBase64)
        {
            byte[] Byte = Convert.FromBase64String(ImageBase64);
            var FilePath = Path.Combine($"{_environment.WebRootPath}/Files/{Guid.NewGuid()}.jpg");
            await System.IO.File.WriteAllBytesAsync(FilePath, Byte);
            return "آپلود عکس با موفقیت انجام شد";
        }
    }
}
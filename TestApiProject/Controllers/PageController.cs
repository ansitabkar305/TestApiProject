using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TestApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        [HttpGet]
        public string Say()
        {
            return Convert.ToString(DateTime.Now);
        }
    }
}

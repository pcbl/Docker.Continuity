using DotNetCore.HelloService.WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.HelloService.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Hello")]
    public class HelloController : Controller
    {
        // GET api/Hello/Pedro
        [HttpGet("{firstName}")]
        public Greeting Get(string firstName)
        {
            return new Greeting(){Name=firstName};
        }

    }
}
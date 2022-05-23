using ECommAppAPI.Errors;
using Microsoft.AspNetCore.Mvc;

namespace ECommAppAPI.Controllers
{
    [Route("UrlError/{code}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class UrlErrorController : BaseApiController
    {
        //[HttpGet("UError")]
        public IActionResult UError(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}

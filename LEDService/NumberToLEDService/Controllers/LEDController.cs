using NumberToLEDService.Service;
using System.Web.Http;



namespace NumberToLEDService.Controllers
{
    public class LEDController : ApiController
    {
        
       [Route("api/LED/{number:decimal}")]
       [HttpGet]
        public IHttpActionResult GetDisplay(decimal number)
        {                        
            return Ok(LED.GetDisplayInfo(number));
        }

    }
}

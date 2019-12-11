using DomainModel;

using Microsoft.AspNetCore.Mvc;
namespace RuntimeXamlApi
{
    [ApiController]
    [Produces("application/json")]
    public class Sample1Controller : ControllerBase
    {
        [Route("~/api/GetSample1")]
        [HttpGet]
        public Response<string> GetSample1()
        {
            string button = "<Button Text=\"A L E R T\" FontSize=\"20\" FontAttributes=\"Bold\" BackgroundColor=\"LightSkyBlue\" TextColor=\"White\"/>";

            var resp = new Response<string>(button, new Response() { Status = "Success", ReturnCode = "200", ResponseTo = "User", Message = "Success" });

            return resp;
        }
    }
}

using DomainModel;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RuntimeXamlApi
{
    /// <summary>
    /// RETURN A BUTTON TO APP
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class Sample1Controller : ControllerBase
    {
        [Route("~/api/GetSample1")]
        [HttpGet]
        public Response<List<string>> GetSample1()
        {
            List<string> list = new List<string>();
            string button = "<Button Text=\"A L E R T\" FontSize=\"20\" FontAttributes=\"Bold\" BackgroundColor=\"LightSkyBlue\" TextColor=\"White\"/>";

            list.Add(button);
            var resp = new Response<List<string>>(list, new Response() { Status = "Success", ReturnCode = "200", ResponseTo = "User", Message = "Success" });

            return resp;
        }
    }
}

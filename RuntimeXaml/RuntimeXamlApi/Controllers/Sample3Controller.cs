using DomainModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RuntimeXamlApi
{
    /// <summary>
    /// RETURN A BUTTON TO APP
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class Sample3Controller : ControllerBase
    {
        [Route("~/api/GetSample3")]
        [HttpGet]
        public Response<List<string>> GetSample3()
        {
            List<string> list = new List<string>();
            string button = "<Button Text=\"A L E R T\" FontSize=\"20\" FontAttributes=\"Bold\" BackgroundColor=\"LightSkyBlue\" TextColor=\"White\"/>";

            list.Add(button);
            var resp = new Response<List<string>>(list, new Response() { Status = "Success", ReturnCode = "200", ResponseTo = "User", Message = "Success" });

            return resp;
        }
    }
}

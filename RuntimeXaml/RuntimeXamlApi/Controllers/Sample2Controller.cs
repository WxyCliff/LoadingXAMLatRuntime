using DomainModel;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;

namespace RuntimeXamlApi
{
    /// <summary>
    /// RETURN ENTRY AND BUTTON
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class Sample2Controller : ControllerBase
    {
        [Route("~/api/GetSample2")]
        [HttpGet]
        public Response<List<string>> GetSample2()
        {
            List<string> list = new List<string>();

            string button = "<Button Text=\"A P P L Y\" FontSize=\"20\" FontAttributes=\"Bold\" BackgroundColor=\"LightSkyBlue\" TextColor=\"White\"/>";
            list.Add(button);

            var resp = new Response<List<string>>(list, new Response() { Status = "Success", ReturnCode = "200", ResponseTo = "User", Message = "Success" });

            return resp;
        }


        [Route("~/api/GetSample2Page")]
        [HttpGet]
        public Response<List<string>> GetSample2Page()
        {
            List<string> list = new List<string>();

            string page = "<?xml version=\"1.0\" encoding=\"utf-8\"?><ContentPage xmlns=\"http://xamarin.com/schemas/2014/forms\"\nxmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\nx:Class=\"RuntimeXaml.Sample2Page\"\nTitle=\"Post Items\">\n<StackLayout x:Name=\"_postLayout\">\n<Entry Placeholder=\"WHO\"/>\n<Picker><Picker.Items><x:String>WILL DO</x:String><x:String>WILL ARRIVE</x:String><x:String>WILL MEET</x:String></Picker.Items></Picker>\n<Entry Placeholder=\"Object\"/>\n<Button Text=\"POST\" x:Name=\"_postButton\" />\n</StackLayout>\n</ContentPage>";

            // ADD DATEPICKER
            //string page = "<?xml version=\"1.0\" encoding=\"utf-8\"?><ContentPage xmlns=\"http://xamarin.com/schemas/2014/forms\"\nxmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\nx:Class=\"RuntimeXaml.Sample2Page\"\nTitle=\"Post Items\">\n<StackLayout x:Name=\"_postLayout\">\n<Entry Placeholder=\"WHO\"/>\n<Picker><Picker.Items><x:String>WILL DO</x:String><x:String>WILL ARRIVE</x:String><x:String>WILL MEET</x:String></Picker.Items></Picker>\n<Entry Placeholder=\"Object\"/>\n<DatePicker></DatePicker>\n<Button Text=\"POST\" x:Name=\"_postButton\" />\n</StackLayout>\n</ContentPage>";

            list.Add(page);

            var resp = new Response<List<string>>(list, new Response() { Status = "Success", ReturnCode = "200", ResponseTo = "User", Message = "Success" });

            return resp;
        }


        [Route("~/api/PostSample2")]
        [HttpPost]
        public Response<List<string>> PostSample2(PostData post)
        {
            List<string> list = new List<string>();

            string reslt = $"YOU POST : { string.Join(" ", post.PostStrings)}";

            list.Add(reslt);

            var resp = new Response<List<string>>(list, new Response() { Status = "Success", ReturnCode = "200", ResponseTo = "User", Message = "Success" });

            return resp;
        }
    }
}

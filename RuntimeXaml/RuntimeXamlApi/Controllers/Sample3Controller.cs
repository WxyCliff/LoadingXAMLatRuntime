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
            string button = "<Button Text=\"F l e x L a y o u t\" FontSize=\"20\" FontAttributes=\"Bold\" BackgroundColor=\"LightSkyBlue\" TextColor=\"White\"/>";

            list.Add(button);
            var resp = new Response<List<string>>(list, new Response() { Status = "Success", ReturnCode = "200", ResponseTo = "User", Message = "Success" });

            return resp;
        }

        [Route("~/api/GetSample3Page")]
        [HttpGet]
        public Response<List<string>> GetSample3Page()
        {
            List<string> list = new List<string>();

            string page = "<ContentPage xmlns=\"http://xamarin.com/schemas/2014/forms\" xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\" xmlns:d=\"http://xamarin.com/schemas/2014/forms/design\"  xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" mc:Ignorable=\"d\" x:Class=\"RuntimeXaml.Sample3Page\" xmlns:local=\"clr-namespace:RuntimeXaml\" Title=\"Sample3\"  >\n <ScrollView Orientation=\"Both\">\n <FlexLayout>\n <Frame WidthRequest=\"300\" HeightRequest=\"480\"> \n<FlexLayout Direction=\"Column\">\n <Label Text=\"Xamarin\" />\n <Label Text=\"Written in\" />\n <Label Text=\"  &#x2022; C#\" /> \n<Image Source=\"https://runtimexaml.azurewebsites.net/images/xamarin.png\" WidthRequest=\"180\" HeightRequest=\"180\" /> \n <Label FlexLayout.Grow=\"1\" />\n </FlexLayout>\n</Frame>\n <Frame WidthRequest=\"300\"  HeightRequest=\"480\">\n <FlexLayout Direction=\"Column\">\n <Label Text=\"iOS\" />\n <Label Text=\"Written in\" />\n <Label Text=\"  &#x2022; C\" />\n <Label Text=\"  &#x2022; C++\" />\n <Label Text=\"  &#x2022; Objective-C\" />\n <Label Text=\"  &#x2022; Swift\" />\n <Image Source=\"https://runtimexaml.azurewebsites.net/images/iOS.png\" WidthRequest=\"240\" HeightRequest=\"180\" />\n <Label FlexLayout.Grow=\"1\" />\n </FlexLayout>\n </Frame>\n <Frame WidthRequest=\"300\"  HeightRequest=\"480\">\n<FlexLayout Direction=\"Column\"> \n <Label Text=\"Android\" /> \n <Label Text=\"Written in\" /> \n <Label Text=\"  &#x2022; Java (UI)\" />\n <Label Text=\"  &#x2022; C (core)\" /> \n <Label Text=\"  &#x2022; C++\" /> \n <Label Text=\"  &#x2022; Kotlin\" /> \n <Label Text=\"  &#x2022; Python\" /> \n <Image Source=\"https://runtimexaml.azurewebsites.net/images/android.png\" WidthRequest=\"180\" HeightRequest=\"180\" /> \n <Label FlexLayout.Grow=\"1\" /> \n </FlexLayout> \n </Frame> \n </FlexLayout> \n </ScrollView> \n </ContentPage>";


            list.Add(page);

            var resp = new Response<List<string>>(list, new Response() { Status = "Success", ReturnCode = "200", ResponseTo = "User", Message = "Success" });

            return resp;
        }
    }
}

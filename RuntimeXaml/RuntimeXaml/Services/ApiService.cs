using DomainModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeXaml.Services
{
    public class ApiService : IApiService
    {
        HttpClient client;

        string apiElement;
        public ApiService()
        {
            client = new HttpClient();
            apiElement = string.Empty;
        }


        public async Task<string> GetSample1Button()
        {
            var uri = new Uri($"{App.ApiBackendUrl}{"GetSample1"}");

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    apiElement = JsonConvert.DeserializeObject<Response<string>>(content).Result;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return apiElement;
        }
    }
}


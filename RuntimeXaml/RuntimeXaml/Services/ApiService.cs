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

        List<string> apiElement;
        public ApiService()
        {
            client = new HttpClient();
            apiElement = new List<string>();
        }

        public async Task<List<string>> GetXamlItems(string apiName)
        {
            var uri = new Uri($"{App.ApiBackendUrl}{apiName}");

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    apiElement = JsonConvert.DeserializeObject<Response<List<string>>>(content).Result;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
            return apiElement;
        }

        public async Task<List<string>> PostItems(PostData postData)
        {
            var uri = new Uri($"{App.ApiBackendUrl}PostSample2");

            try
            {
                var json = JsonConvert.SerializeObject(postData);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(uri, content);


                if (response.IsSuccessStatusCode)
                {
                    var respContent = await response.Content.ReadAsStringAsync();
                    apiElement = JsonConvert.DeserializeObject<Response<List<string>>>(respContent).Result;
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


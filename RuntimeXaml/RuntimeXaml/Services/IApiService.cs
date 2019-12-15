using DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeXaml.Services
{
    public interface IApiService
    {
        Task<List<string>> GetXamlItems(string apiName);

        Task<List<string>> PostItems(PostData postData);
    }
}

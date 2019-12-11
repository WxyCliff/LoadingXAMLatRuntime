using DomainModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeXaml.Services
{
    public interface IApiService
    {
        Task<string> GetSample1Button();
    }
}

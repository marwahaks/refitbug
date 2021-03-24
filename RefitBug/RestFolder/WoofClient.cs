using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RefitBug.RestFolder;

namespace RefitBug.RestFolder
{
    class WoofClient
    {
        public IWoofClient IWoofClient;
        public Uri _baseUrl;
        public WoofClient()
        {
            _baseUrl = new Uri("https://random.dog/");

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            IWoofClient = Refit.RestService.For<IWoofClient>(
            new HttpClient()
            {
                BaseAddress = _baseUrl
            });
        }

        public async Task<bool> GetMyDawg()
        {
            var apiResponse = await IWoofClient.GetDawg();
            return string.IsNullOrWhiteSpace(apiResponse.Url);
        }
    }
}

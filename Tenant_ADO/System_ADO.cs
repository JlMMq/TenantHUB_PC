using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_ADO
{
    public class System_ADO
    {
        public string restService;
        public string urlEndPoint;

        public System_ADO(string _urlEndpoint)
        {
            this.urlEndPoint = _urlEndpoint;
        }

        public bool RunningService(string url)
        {
            bool val = false;
            restService = url + "Main/run";
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Get;
                var response = client.Execute<bool>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    val = JsonConvert.DeserializeObject<bool>(response.Content);
                }
            }
            catch(Exception ex)
            {
                val = false;
            }
            return val;
        }

    }
}

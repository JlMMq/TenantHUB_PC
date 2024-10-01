using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tenant_BE;

namespace Tenant_ADO
{
    public class Documento_ADO
    {
        public string restService;
        public string urlEndPoint;

        public Documento_ADO(string _urlEndPoint)
        {
            urlEndPoint = _urlEndPoint;
        }

        public List<Documento_BE> ListDocumento()
        {
            restService = urlEndPoint + "Documento/ListDocumento";
            List<Documento_BE> list = new List<Documento_BE>();
            try
            {
                var client = new RestClient(restService);
                var request = new RestRequest();
                request.Method = Method.Get;
                var response = client.Execute<List<Documento_BE>>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    list = JsonConvert.DeserializeObject<List<Documento_BE>>(response.Content);
                }
            }
            catch(Exception ex)
            {
                list = new List<Documento_BE>();
            }
            return list;
        }
    }
}

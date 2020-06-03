using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RestSharp.Serialization.Json;
using NexGenAPi;

namespace NexGenAPi
{
     public class Bundles
    {
        public BundlesDTO GetBundles()
        {
            var restClient = new RestClient("http://shop-api.my.mtn.com/");
            var restRequest = new RestRequest("api/v1/bundles", Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var bundles = JsonConvert.DeserializeObject<BundlesDTO>(content);
            return bundles;
        }
    }
}

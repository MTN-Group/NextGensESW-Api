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
    public class MyMTN
    {
        public Products GetProducts()
        {
            var restClient = new RestClient("http://shop-api.my.mtn.com/");
            var restRequest = new RestRequest("api/v1/products", Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var products = JsonConvert.DeserializeObject<Products>(content);
            return products;
        }
    }
}

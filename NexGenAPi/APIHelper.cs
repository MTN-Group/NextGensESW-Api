using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexGenAPi
{
   public class APIHelper<T>
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public string baseUrl = "http://shop-api.my.mtn.com/";

        public RestClient SetUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            var restClient = new RestClient(url);
            return restClient;
        }

        public RestRequest CreatePostRequest(string payload)  //Payload = RequestBody
        {
            var resRequest = new RestRequest(Method.POST);
            resRequest.AddHeader("Accept", "application/json");
            resRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return resRequest;


        }

        public RestRequest CreateGetRequest(string payload)  //Payload = RequestBody
        {
            var resRequest = new RestRequest(Method.GET);
            resRequest.AddHeader("Accept", "application/json");
            //resRequest.AddParameter("application/json", payload, ParameterType.RequestBody);
            return resRequest;
        }

        public IRestResponse GetRestResponse(RestClient client, RestRequest request)
        {
            return client.Execute(request);

        }

        public DTO GetContent<DTO>(IRestResponse response)
        {
            var content = response.Content;
            DTO dtoObject = JsonConvert.DeserializeObject<DTO>(content);
            return dtoObject;
        }



    }
}

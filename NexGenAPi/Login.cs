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
    public class Login<T>
    {
        public LoginDTO UserLogin(string endpoint, dynamic payload)
            {
                var user = new APIHelper<LoginDTO>();
                var url = user.SetUrl(endpoint);
                // var url = user.SetUrl("api/v1/login-sz/26876700060");
                var request = user.CreatePostRequest(payload);
                var response = user.GetRestResponse(url, request);
                LoginDTO content = user.GetContent<LoginDTO>(response);
                 return content;
            }

        public LoginDTO CheckSubscriber(string endpoint, dynamic payload)
        {

            var user = new APIHelper<LoginDTO>();
            var url = user.SetUrl(endpoint);
            // var url = user.SetUrl("api/v1/login-sz/26876700060");
            var request = user.CreatePostRequest(payload);
            var response = user.GetRestResponse(url, request);
            LoginDTO content = user.GetContent<LoginDTO>(response);
            return content;

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexGenAPi;

namespace NextGentApiTests
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string payload = @"{
                                
                                 ""client_id"": ""MyMTN"",
                                  ""client_secret"": ""secret"",
                                  ""otp"": ""1439"",
                                  ""grant_type"": ""password"",
                                 ""scope"": ""NextGenAPI.Access offline_access""
                                }";

            var user = new APIHelper<LoginDTO>();
            var url = user.SetUrl("/api/v1/login-sz/26876700060");
            var request = user.CreatePostRequest(payload);
            var response = user.GetRestResponse(url, request);
            LoginDTO content = user.GetContent<LoginDTO>(response);
            Assert.AreEqual("false", content.meta.success);
            Assert.AreEqual("AMARNATH REDDY ANDEM", content.meta.experience.user.first_name);
            Assert.IsNotNull(content.meta.experience.user.access_token);

        }
    }
}

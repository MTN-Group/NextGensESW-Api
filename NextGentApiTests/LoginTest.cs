using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexGenAPi;

namespace NextGentApiTests
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void ValidMSISDN()
        {
            string payload = @"{
                                
                                 ""client_id"": ""MyMTN"",
                                  ""client_secret"": ""secret"",
                                  ""otp"": ""1234"",
                                  ""grant_type"": ""password"",
                                 ""scope"": ""NextGenAPI.Access offline_access""
                                }";

            var login = new Login<LoginDTO>();
            var User = login.UserLogin("api/v1/login-sz/26876700060", payload);

            Assert.AreEqual("false", User.Meta[0].experience.user.success);
            Assert.AreEqual("AMARNATH REDDY ANDEM", User.Meta[0].experience.user.first_name);
            Assert.IsNotNull(User.Meta[0].experience.user.access_token);

        }

        [TestMethod]
        public void InvalidMSISDN()
        {
            string payload = @"{
                                
                                 ""client_id"": ""MyMTN"",
                                  ""client_secret"": ""secret"",
                                  ""otp"": ""1234"",
                                  ""grant_type"": ""password"",
                                 ""scope"": ""NextGenAPI.Access offline_access""
                                }";

            var login = new Login<LoginDTO>();
            var User = login.UserLogin("api/v1/login-sz/26879898729", payload);

            Assert.AreEqual("false", User.Meta[0].experience.user.success);
            Assert.AreEqual("AMARNATH REDDY ANDEM", User.Meta[0].experience.user.first_name);
            Assert.IsNotNull(User.Meta[0].experience.user.access_token);

        }

        [TestMethod]
        public void AccessToken()
        {
            string payload = @"{
                                
                                 ""client_id"": ""MyMTN"",
                                  ""client_secret"": ""secret"",
                                  ""otp"": ""1234"",
                                  ""grant_type"": ""password"",
                                 ""scope"": ""NextGenAPI.Access offline_access""
                                }";

            var login = new Login<LoginDTO>();
            var User = login.UserLogin("api/v1/login-sz/26876700060", payload);

            Assert.AreEqual("false", User.Meta[0].experience.user.success);
            
            Assert.IsNotNull(User.Meta[0].experience.user.access_token);
            AccessToken();

        }

    }
}

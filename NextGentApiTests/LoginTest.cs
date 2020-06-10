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
    }
}

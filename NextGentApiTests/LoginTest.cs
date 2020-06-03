using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        }
    }
}

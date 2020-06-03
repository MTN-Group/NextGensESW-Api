using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NexGenAPi;

namespace NextGentApiTests
{
    [TestClass]
    public class BundlesTest
    {
        [TestMethod]
        public void VerifyBundles()
        {
            var myBundles = new Bundles();
            var response = myBundles.GetBundles();
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("Daily Facebook 30MB", response.Response[0].Bundle_Name);
        }

        [TestMethod]
        public void VerifyNactCode()
        {
            var myBundles = new Bundles();
            var response = myBundles.GetBundles();
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("NACT_SWZ_Data_855", response.Response[0].Bundle_Nact_Code);
        }

        [TestMethod]
        public void VerifyBundleRules()
        {
            var myBundles = new Bundles();
            var response = myBundles.GetBundles();
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("9", response.Response[0].Bundle_Rule[0].Rule_Id);
        }
    }
}

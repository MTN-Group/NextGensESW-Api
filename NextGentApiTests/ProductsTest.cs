using System;
using NexGenAPi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NextGentApiTests
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void VerifyProducts()
        {
            var myMtnApp = new MyMTN<Products>();
            var response = myMtnApp.GetProducts();
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("MTN DATA Bundles", response.Response[0].Product_Description);
        }

        [TestMethod]
        public void VerifyName()
        {
            var myMtnApp = new MyMTN<Products>();
            var response = myMtnApp.GetProducts();
            Assert.AreEqual(200, response.StatusCode);
            Assert.AreEqual("Data", response.Response[0].Product_Name);
        }


    }
}

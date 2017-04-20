using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Micronet_User.Controllers;
using System.Web.Mvc;

namespace Micronet_User.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       public void TestMethod1()
        {
            var controller =  new UserController() ;
            

            ViewResult r = controller.Index() as ViewResult;
            Assert.IsNotNull(r);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var controller = new UserController();
            //var result = controller.UserProfile() as ViewResult;

            ViewResult r = controller.UserProfile() as ViewResult;
            Assert.IsNotNull(r);
        }
    }
}

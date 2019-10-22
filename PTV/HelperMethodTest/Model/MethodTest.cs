using Microsoft.VisualStudio.TestTools.UnitTesting;
using PTV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTV.Model;

namespace HelperMethodTest.Tests
{
    [TestClass()]
    public class MethodTest
    {
        [TestMethod()]
        public void RemoveWhiteSpaceTest()
        {
            string aurl = "williams landingstation";
            string url = Signature.remove_white_spaces(aurl);

            Assert.AreEqual(url, "williams%20landingstation");
        }
    }
}
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
            string url = "/v3/search/" + "g e";
            string req = Signature.remove_white_spaces(url);

            Assert.AreEqual(req, "/v3/search/" + "g%20e");
        }

        
    }
}
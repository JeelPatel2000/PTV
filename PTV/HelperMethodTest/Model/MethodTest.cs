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
            string req = Signature.CalcuteSignature(url);

            Assert.AreEqual(req, "http://timetableapi.ptv.vic.gov.au/v3/search/g%20e?devid=3001296&signature=13BEBACEE31A9EAE53B5F115A4D09897903BDA72");
        }
    }
}
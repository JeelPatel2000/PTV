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

        [TestMethod()]
        public void TestCalculateSignature()
        {
            string url = "/v3/departures/route_type/" +"1"+ "/stop/"+"2";
            string request = Signature.CalcuteSignature(url);
            string expect = "/v3/departures/route_type/1/stop/2?devid=3001296&signature=5FB4E172B5E78B91C8035C9E058DDB60CE5B9C34";
            Assert.AreEqual(expect, request);
        }
    }
}
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
        public void CalculateSignatureTest()
        {
            string url = "/v3/departures/route_type/0/stop/1225?date_utc=2019-10-25T22%3A45%3A00Z";
            string signature = Signature.CalcuteSignature(url);
            string expected = "/v3/departures/route_type/0/stop/1225?date_utc=2019-10-25T22%3A45%3A00Z&devid=3001296&signature=74AB2D01C4B9961036A578AF8032A90485E0F53F";
            Assert.AreEqual(signature, expected);
        }

        

        [TestMethod()]
        public void getTimeTest()
        {
            string now = UTC_Date_Time.getDateTime();

            
            
        }
    }
}
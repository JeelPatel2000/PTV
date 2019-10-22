using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTV
{
    public class Signature
    {
        private static string key = "2765ded7-ed93-4e8c-87ff-dfda9edc0bc8"; // supplied by PTV
        private static int developerId = 3001296; // supplied by PTV

        public static string CalcuteSignature(string url)
        {  
            // add developer id
            url = string.Format("{0}{1}devid={2}", url, url.Contains("?") ? "&" : "?", developerId);
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            // encode key
            byte[] keyBytes = encoding.GetBytes(key);
            // encode url
            byte[] urlBytes = encoding.GetBytes(url);
            byte[] tokenBytes = new System.Security.Cryptography.HMACSHA1(keyBytes).ComputeHash(urlBytes);
            var sb = new System.Text.StringBuilder();
            // convert signature to string
            Array.ForEach<byte>(tokenBytes, x => sb.Append(x.ToString("X2")));
            // add signature to url
            url = string.Format("{0}&signature={1}", url, sb.ToString());

            // extra code to add base URL – the resultant url should be:
            //  http://timetableapi.ptv.vic.gov.au/v2/mode/2/line/787/stops-for-line?devid=2&signature=D5474F344CDAA7B92F2253169F6C1D66C1A15001

            url = remove_white_spaces(url);

            return url;
        }

        public static string remove_white_spaces(string url)
        {
            string new_url = "";
            for (int i = 0; i < url.Length; i++) 
            {
                if(url[i].Equals(" "))
                {
                    new_url += "%20";
                }
                else
                {
                    new_url += url[i];
                }

            }

            return new_url;
        }
    }
}

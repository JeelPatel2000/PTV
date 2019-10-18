using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using Newtonsoft.Json.Linq;

namespace PTV
{
    public class Departures
    {
        // Constructures 
        // Departure(Stop Type, Stop ID)
        // Departure(Stop Type, Stop ID, Direction ID)
        public static async Task<JObject> GetDepartures(int stop_id)
        {
            // the PTV api method we want
            string url = "/v3/departures/route_type/0/stop/" + stop_id;
            // calculating signature
            string request = Signature.CalcuteSignature(url);
            // sending request and returning the object
            return await RequestPTV.SendRequest(request);
        }

        public static async Task<JObject> GetDepartures(int route_type, int stop_id)
        {
            // the PTV api method we want
            string url = "/v3/departures/route_type/" + route_type + "/stop/" + stop_id;
            Console.WriteLine(url);
            // calculating signature
            string request = Signature.CalcuteSignature(url);
            // sending request and returning the object
            return await RequestPTV.SendRequest(request);
        }

        public static async Task<JObject> GetDepartures(int route_type, int stop_id, int route_id)
        {
            // the PTV api method we want
            string url = "/v3/departures/route_type/" + route_type + "/stop/" + stop_id + "/route/" + route_id;
            Console.WriteLine(url);
            // calculating signature
            string request = Signature.CalcuteSignature(url);
            // sending request and returning the object
            return await RequestPTV.SendRequest(request);
        }
    }


}

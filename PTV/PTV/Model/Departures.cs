using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PTV
{
    public class Departures
    {
        /// <summary>
        /// Constructures 
        /// </summary>
        /// <param name="stop_id"></param>
        /// <returns></returns>
        public static async Task<JObject> GetDepartures(int stop_id)
        {
            // the PTV api method we want
            string url = "/v3/departures/route_type/0/stop/" + stop_id;
            // calculating signature
            string request = Signature.CalcuteSignature(url);
            // sending request and returning the object
            return await RequestPTV.SendRequest(request);
        }
        /// <summary>
        /// Departure(Stop Type, Stop ID)
        /// Determine the url based on route_type and stop_id.
        /// Then calculating the signature to use it as a request to PTV website.
        /// </summary>
        /// <param name="route_type"></param>
        /// <param name="stop_id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Departure(Stop Type, Stop ID, Direction ID).
        /// Determine the url based on route_type and stop_id.
        /// Then calculating the signature to use it as a request to PTV website.
        /// </summary>
        /// <param name="route_type"></param>
        /// <param name="stop_id"></param>
        /// <param name="route_id"></param>
        /// <returns></returns>
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

using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using PTV.Model;

namespace PTV
{
    public class Departures
    {
        // Constructures 
        // Departure(Stop Type, Stop ID)
        // Departure(Stop Type, Stop ID, Direction ID)
        public static async Task<JObject> GetDepartures(int stop_id)
        {
            string date_time = UTC_Date_Time.getDateTime();
            Console.WriteLine(date_time);
            // the PTV api method we want
            string url = "/v3/departures/route_type/0/stop/" + stop_id + "?date_utc=" + date_time;
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

        public static async Task<JObject> GetDepartures(int stop_id,string datetime)
        {
            // the PTV api method we want
            string url = "/v3/departures/route_type/0/stop/" + stop_id + "?date_utc=2019-10-25T22%3A45%3A00Z&";
            // calculating signature
            string request = Signature.CalcuteSignature(url);
            // sending request and returning the object
            return await RequestPTV.SendRequest(request);
        }
    }


}

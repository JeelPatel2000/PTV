using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PTV
{
    public class Stops
    {
        public async static Task<JObject> GetStops(int route_id,int route_type)
        {
            // the PTV api method we want
            string url = "/v3/stops/route/" + route_id + "/route_type/" + route_type;
            Console.WriteLine(url);
            // calculating signature
            string request = Signature.CalcuteSignature(url);
            // sending request and returning the object
            return await RequestPTV.SendRequest(request);
        }           

    }
}

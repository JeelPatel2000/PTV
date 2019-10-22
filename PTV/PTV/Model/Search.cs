using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PTV
{
    public class Search
    {
        public static async Task<JObject> GetSearchResult(string search_term)
        {
            // the PTV api method we want
            string url = "/v3/search/" + search_term;
            // calculating signature
            string request = Signature.CalcuteSignature(url);
            // sending request and returning the object
            JObject result = await RequestPTV.SendRequest(request);
            
            return result;
        }

    }
}

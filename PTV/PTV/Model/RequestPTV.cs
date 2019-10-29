using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PTV
{
    public class RequestPTV
    {
        /// <summary>
        /// Sending request to the timetable api website of PTV.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async static Task<JObject> SendRequest(string request)
        {
            JObject jObject = new JObject();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://timetableapi.ptv.vic.gov.au");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync(request);
            

            if (response.IsSuccessStatusCode)
            {
                jObject = JObject.Parse(await response.Content.ReadAsStringAsync());
            }

            return jObject;
        }

    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PTV
{
    public class Search
    {
        /// <summary>
        /// After removing the white space in the searching words, the signature will be calculated and use it to send a request to PTV website.
        /// </summary>
        /// <param name="search_term"></param>
        /// <returns></returns>
        public static async Task<JObject> GetSearchResult(string search_term)
        {
            search_term = remove_white_spaces(search_term);
            // the PTV api method we want
            string url = "/v3/search/" + search_term;
            // calculating signature
            string request = Signature.CalcuteSignature(url);
            Console.WriteLine(request);
            // sending request and returning the object
            JObject result = await RequestPTV.SendRequest(request);
            
            return result;
        }
        /// <summary>
        /// To remove the white space in the input box to corresponding symbol of the signature.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string remove_white_spaces(string url)
        {
            string new_url = "";

            url = url.Trim();

            foreach (char c in url)
            {
                if (c.Equals(' '))
                {
                    new_url += "%20";
                }
                else
                {
                    new_url += c;
                }
            }
            Console.WriteLine(new_url);

            return new_url;
        }
    }
}

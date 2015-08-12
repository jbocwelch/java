﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using rosette_api;

namespace rosette_apiExamples
{
    class entities_linked
    {
        /// <summary>
        /// Example code to call Rosette API to get linked (against Wikipedia) entities from a piece of text.
        /// Requires Nuget Package:
        /// rosette_api
        /// </summary>
        static void Main()
        {
            //To use the C# API, you must provide an API key
            CAPI EntitiesLinkedCAPI = new CAPI("your API key");
            try
            {
                //The results of the API call will come back in the form of a Dictionary
                Dictionary<string, Object> EntitiesLinkedResult = EntitiesLinkedCAPI.EntitiesLinked("${entities_linked_data}");
                Console.WriteLine(new JavaScriptSerializer().Serialize(EntitiesLinkedResult));
            }
            catch (RosetteException e)
            {
                Console.WriteLine("Error Code " + e.Code.ToString() + ":" + e.Message);
            }
        }
    }
}